#!/bin/bash

INCLUDE_SIMULATOR=true
PROJECT_PATH="../../FSCalendar/FSCalendarExamples.xcworkspace"
BUILD_PATH="build/Build/Products"
PROJECT="FSCalendar"

echo "Build iOS framework for simulator and device"
rm -Rf "Aztec.framework"
if $INCLUDE_SIMULATOR; then
    xcodebuild -sdk iphonesimulator -workspace $PROJECT_PATH -scheme FSCalendar -arch x86_64 -configuration Release -derivedDataPath "build" > /dev/null
fi
xcodebuild -sdk iphoneos -workspace $PROJECT_PATH -scheme FSCalendar -arch arm64 -configuration Release -derivedDataPath "build" > /dev/null

echo "Create fat binaries for Release-iphoneos and Release-iphonesimulator configuration"
echo "Copy one build as a fat framework"

if $INCLUDE_SIMULATOR; then
    echo "Combine modules from another build with the fat framework modules"
    cp -R "$BUILD_PATH/Release-iphonesimulator/$PROJECT.framework/Modules/$PROJECT.swiftmodule/" "$BUILD_PATH/Release-iphoneos/$PROJECT.framework/Modules/$PROJECT.swiftmodule/"
    echo "Combine iphoneos + iphonesimulator configuration as fat libraries"
    lipo -create -output "$BUILD_PATH/Release-iphoneos/$PROJECT.framework/$PROJECT" "$BUILD_PATH/Release-iphoneos/$PROJECT.framework/$PROJECT" "$BUILD_PATH/Release-iphonesimulator/$PROJECT.framework/$PROJECT"
fi

cp -R "$BUILD_PATH/Release-iphoneos/FSCalendar.framework" "."
rm -Rf "build"

echo "Verify results"
lipo -info "FSCalendar.framework/FSCalendar"

sharpie bind --sdk=iphoneos --namespace=FSCalendar -scope FSCalendar.framework/Headers/ FSCalendar.framework/Headers/*.h