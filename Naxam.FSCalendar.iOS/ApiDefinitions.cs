using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FSCalendarAbstractions
{
    [Static]
    partial interface Constants
    {
        // extern const CGFloat FSCalendarStandardHeaderHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardHeaderHeight", "__Internal")]
        nfloat FSCalendarStandardHeaderHeight { get; }

        // extern const CGFloat FSCalendarStandardWeekdayHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeekdayHeight", "__Internal")]
        nfloat FSCalendarStandardWeekdayHeight { get; }

        // extern const CGFloat FSCalendarStandardMonthlyPageHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardMonthlyPageHeight", "__Internal")]
        nfloat FSCalendarStandardMonthlyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardWeeklyPageHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeeklyPageHeight", "__Internal")]
        nfloat FSCalendarStandardWeeklyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardCellDiameter __attribute__((visibility("default")));
        [Field("FSCalendarStandardCellDiameter", "__Internal")]
        nfloat FSCalendarStandardCellDiameter { get; }

        // extern const CGFloat FSCalendarStandardSeparatorThickness __attribute__((visibility("default")));
        [Field("FSCalendarStandardSeparatorThickness", "__Internal")]
        nfloat FSCalendarStandardSeparatorThickness { get; }

        // extern const CGFloat FSCalendarAutomaticDimension __attribute__((visibility("default")));
        [Field("FSCalendarAutomaticDimension", "__Internal")]
        nfloat FSCalendarAutomaticDimension { get; }

        // extern const CGFloat FSCalendarDefaultBounceAnimationDuration __attribute__((visibility("default")));
        [Field("FSCalendarDefaultBounceAnimationDuration", "__Internal")]
        nfloat FSCalendarDefaultBounceAnimationDuration { get; }

        // extern const CGFloat FSCalendarStandardRowHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardRowHeight", "__Internal")]
        nfloat FSCalendarStandardRowHeight { get; }

        // extern const CGFloat FSCalendarStandardTitleTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardTitleTextSize", "__Internal")]
        nfloat FSCalendarStandardTitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardSubtitleTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardSubtitleTextSize", "__Internal")]
        nfloat FSCalendarStandardSubtitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardWeekdayTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeekdayTextSize", "__Internal")]
        nfloat FSCalendarStandardWeekdayTextSize { get; }

        // extern const CGFloat FSCalendarStandardHeaderTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardHeaderTextSize", "__Internal")]
        nfloat FSCalendarStandardHeaderTextSize { get; }

        // extern const CGFloat FSCalendarMaximumEventDotDiameter __attribute__((visibility("default")));
        [Field("FSCalendarMaximumEventDotDiameter", "__Internal")]
        nfloat FSCalendarMaximumEventDotDiameter { get; }

        // extern const NSInteger FSCalendarDefaultHourComponent __attribute__((visibility("default")));
        [Field("FSCalendarDefaultHourComponent", "__Internal")]
        nint FSCalendarDefaultHourComponent { get; }

        // extern const NSInteger FSCalendarMaximumNumberOfEvents __attribute__((visibility("default")));
        [Field("FSCalendarMaximumNumberOfEvents", "__Internal")]
        nint FSCalendarMaximumNumberOfEvents { get; }

        // extern NSString *const FSCalendarDefaultCellReuseIdentifier __attribute__((visibility("default")));
        [Field("FSCalendarDefaultCellReuseIdentifier", "__Internal")]
        NSString FSCalendarDefaultCellReuseIdentifier { get; }

        // extern NSString *const FSCalendarBlankCellReuseIdentifier __attribute__((visibility("default")));
        [Field("FSCalendarBlankCellReuseIdentifier", "__Internal")]
        NSString FSCalendarBlankCellReuseIdentifier { get; }

        // extern NSString *const FSCalendarInvalidArgumentsExceptionName __attribute__((visibility("default")));
        [Field("FSCalendarInvalidArgumentsExceptionName", "__Internal")]
        NSString FSCalendarInvalidArgumentsExceptionName { get; }

        //// extern const CGPoint CGPointInfinity __attribute__((visibility("default")));
        //[Field ("CGPointInfinity", "__Internal")]
        //CGPoint CGPointInfinity { get; }

        //// extern const CGSize CGSizeAutomatic __attribute__((visibility("default")));
        //[Field ("CGSizeAutomatic", "__Internal")]
        //CGSize CGSizeAutomatic { get; }

        // extern double FSCalendarVersionNumber;
        [Field("FSCalendarVersionNumber", "__Internal")]
        double FSCalendarVersionNumber { get; }

        //// extern const unsigned char [] FSCalendarVersionString;
        //[Field ("FSCalendarVersionString", "__Internal")]
        //byte[] FSCalendarVersionString { get; }
    }

    // @interface FSCalendarAppearance : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarAppearance
    {
        // @property (nonatomic, strong) UIFont * titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * subtitleFont;
        [Export("subtitleFont", ArgumentSemantic.Strong)]
        UIFont SubtitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * weekdayFont;
        [Export("weekdayFont", ArgumentSemantic.Strong)]
        UIFont WeekdayFont { get; set; }

        // @property (nonatomic, strong) UIFont * headerTitleFont;
        [Export("headerTitleFont", ArgumentSemantic.Strong)]
        UIFont HeaderTitleFont { get; set; }

        // @property (assign, nonatomic) CGPoint headerTitleOffset;
        [Export("headerTitleOffset", ArgumentSemantic.Assign)]
        CGPoint HeaderTitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint titleOffset;
        [Export("titleOffset", ArgumentSemantic.Assign)]
        CGPoint TitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint subtitleOffset;
        [Export("subtitleOffset", ArgumentSemantic.Assign)]
        CGPoint SubtitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint eventOffset;
        [Export("eventOffset", ArgumentSemantic.Assign)]
        CGPoint EventOffset { get; set; }

        // @property (assign, nonatomic) CGPoint imageOffset;
        [Export("imageOffset", ArgumentSemantic.Assign)]
        CGPoint ImageOffset { get; set; }

        // @property (nonatomic, strong) UIColor * eventDefaultColor;
        [Export("eventDefaultColor", ArgumentSemantic.Strong)]
        UIColor EventDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * eventSelectionColor;
        [Export("eventSelectionColor", ArgumentSemantic.Strong)]
        UIColor EventSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * weekdayTextColor;
        [Export("weekdayTextColor", ArgumentSemantic.Strong)]
        UIColor WeekdayTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * headerTitleColor;
        [Export("headerTitleColor", ArgumentSemantic.Strong)]
        UIColor HeaderTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * headerSeparatorColor;
        [Export("headerSeparatorColor", ArgumentSemantic.Strong)]
        UIColor HeaderSeparatorColor { get; set; }

        // @property (nonatomic, strong) NSString * headerDateFormat;
        [Export("headerDateFormat", ArgumentSemantic.Strong)]
        string HeaderDateFormat { get; set; }

        // @property (assign, nonatomic) NSTextAlignment headerTitleAlignment;
        [Export("headerTitleAlignment", ArgumentSemantic.Assign)]
        UITextAlignment HeaderTitleAlignment { get; set; }

        // @property (assign, nonatomic) CGFloat headerMinimumDissolvedAlpha;
        [Export("headerMinimumDissolvedAlpha")]
        nfloat HeaderMinimumDissolvedAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * titleDefaultColor;
        [Export("titleDefaultColor", ArgumentSemantic.Strong)]
        UIColor TitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleSelectionColor;
        [Export("titleSelectionColor", ArgumentSemantic.Strong)]
        UIColor TitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleTodayColor;
        [Export("titleTodayColor", ArgumentSemantic.Strong)]
        UIColor TitleTodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * titlePlaceholderColor;
        [Export("titlePlaceholderColor", ArgumentSemantic.Strong)]
        UIColor TitlePlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleWeekendColor;
        [Export("titleWeekendColor", ArgumentSemantic.Strong)]
        UIColor TitleWeekendColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleDefaultColor;
        [Export("subtitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor SubtitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleSelectionColor;
        [Export("subtitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor SubtitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleTodayColor;
        [Export("subtitleTodayColor", ArgumentSemantic.Strong)]
        UIColor SubtitleTodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitlePlaceholderColor;
        [Export("subtitlePlaceholderColor", ArgumentSemantic.Strong)]
        UIColor SubtitlePlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleWeekendColor;
        [Export("subtitleWeekendColor", ArgumentSemantic.Strong)]
        UIColor SubtitleWeekendColor { get; set; }

        // @property (nonatomic, strong) UIColor * selectionColor;
        [Export("selectionColor", ArgumentSemantic.Strong)]
        UIColor SelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * todayColor;
        [Export("todayColor", ArgumentSemantic.Strong)]
        UIColor TodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * todaySelectionColor;
        [Export("todaySelectionColor", ArgumentSemantic.Strong)]
        UIColor TodaySelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * borderDefaultColor;
        [Export("borderDefaultColor", ArgumentSemantic.Strong)]
        UIColor BorderDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * borderSelectionColor;
        [Export("borderSelectionColor", ArgumentSemantic.Strong)]
        UIColor BorderSelectionColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderRadius;
        [Export("borderRadius")]
        nfloat BorderRadius { get; set; }

        // @property (assign, nonatomic) FSCalendarCaseOptions caseOptions;
        [Export("caseOptions", ArgumentSemantic.Assign)]
        FSCalendarCaseOptions CaseOptions { get; set; }

        // @property (assign, nonatomic) FSCalendarSeparators separators;
        [Export("separators", ArgumentSemantic.Assign)]
        FSCalendarSeparators Separators { get; set; }

        // @property (readwrite, nonatomic) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Assign)]
        FSCalendar Calendar { get; set; }

        // @property (readonly, nonatomic) NSDictionary * backgroundColors;
        [Export("backgroundColors")]
        NSDictionary BackgroundColors { get; }

        // @property (readonly, nonatomic) NSDictionary * titleColors;
        [Export("titleColors")]
        NSDictionary TitleColors { get; }

        // @property (readonly, nonatomic) NSDictionary * subtitleColors;
        [Export("subtitleColors")]
        NSDictionary SubtitleColors { get; }

        // @property (readonly, nonatomic) NSDictionary * borderColors;
        [Export("borderColors")]
        NSDictionary BorderColors { get; }
    }

    // @interface FSCalendarCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarCell
    {
        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) UILabel * subtitleLabel;
        [Export("subtitleLabel", ArgumentSemantic.Weak)]
        UILabel SubtitleLabel { get; set; }

        // @property (nonatomic, weak) CAShapeLayer * shapeLayer;
        [Export("shapeLayer", ArgumentSemantic.Weak)]
        CAShapeLayer ShapeLayer { get; set; }

        // @property (nonatomic, weak) UIImageView * imageView;
        [Export("imageView", ArgumentSemantic.Weak)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, weak) FSCalendarEventIndicator * eventIndicator;
        [Export("eventIndicator", ArgumentSemantic.Weak)]
        FSCalendarEventIndicator EventIndicator { get; set; }

        // @property (getter = isPlaceholder, assign, nonatomic) BOOL placeholder;
        [Export("placeholder")]
        bool Placeholder { [Bind("isPlaceholder")] get; set; }

        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarAppearance * appearance;
        [Export("appearance", ArgumentSemantic.Weak)]
        FSCalendarAppearance FSAppearance { get; set; }

        // @property (nonatomic, strong) NSString * subtitle;
        [Export("subtitle", ArgumentSemantic.Strong)]
        string Subtitle { get; set; }

        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (assign, nonatomic) FSCalendarMonthPosition monthPosition;
        [Export("monthPosition", ArgumentSemantic.Assign)]
        FSCalendarMonthPosition MonthPosition { get; set; }

        // @property (assign, nonatomic) NSInteger numberOfEvents;
        [Export("numberOfEvents")]
        nint NumberOfEvents { get; set; }

        // @property (assign, nonatomic) BOOL dateIsToday;
        [Export("dateIsToday")]
        bool DateIsToday { get; set; }

        // @property (assign, nonatomic) BOOL weekend;
        [Export("weekend")]
        bool Weekend { get; set; }

        // @property (nonatomic, strong) UIColor * preferredFillDefaultColor;
        [Export("preferredFillDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredFillDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredFillSelectionColor;
        [Export("preferredFillSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredFillSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredTitleDefaultColor;
        [Export("preferredTitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredTitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredTitleSelectionColor;
        [Export("preferredTitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredTitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredSubtitleDefaultColor;
        [Export("preferredSubtitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredSubtitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredSubtitleSelectionColor;
        [Export("preferredSubtitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredSubtitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredBorderDefaultColor;
        [Export("preferredBorderDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredBorderDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredBorderSelectionColor;
        [Export("preferredBorderSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredBorderSelectionColor { get; set; }

        // @property (assign, nonatomic) CGPoint preferredTitleOffset;
        [Export("preferredTitleOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredTitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredSubtitleOffset;
        [Export("preferredSubtitleOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredSubtitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredImageOffset;
        [Export("preferredImageOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredImageOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredEventOffset;
        [Export("preferredEventOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredEventOffset { get; set; }

        // @property (nonatomic, strong) NSArray<UIColor *> * preferredEventDefaultColors;
        [Export("preferredEventDefaultColors", ArgumentSemantic.Strong)]
        UIColor[] PreferredEventDefaultColors { get; set; }

        // @property (nonatomic, strong) NSArray<UIColor *> * preferredEventSelectionColors;
        [Export("preferredEventSelectionColors", ArgumentSemantic.Strong)]
        UIColor[] PreferredEventSelectionColors { get; set; }

        // @property (assign, nonatomic) CGFloat preferredBorderRadius;
        [Export("preferredBorderRadius")]
        nfloat PreferredBorderRadius { get; set; }

        // -(instancetype)initWithFrame:(CGRect)frame __attribute__((objc_requires_super));
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        // -(instancetype)initWithCoder:(NSCoder *)aDecoder __attribute__((objc_requires_super));
        //[Export("initWithCoder:")]
        //[RequiresSuper]
        //IntPtr Constructor (NSCoder aDecoder);

        // -(void)layoutSubviews __attribute__((objc_requires_super));
        //[Export("layoutSubviews")]
        //[RequiresSuper]
        //void LayoutSubviews();

        // -(void)configureAppearance __attribute__((objc_requires_super));
        [Export("configureAppearance")]
        [RequiresSuper]
        void ConfigureAppearance();

        // -(UIColor *)colorForCurrentStateInDictionary:(NSDictionary *)dictionary;
        [Export("colorForCurrentStateInDictionary:")]
        UIColor ColorForCurrentStateInDictionary(NSDictionary dictionary);

        // -(void)performSelecting;
        [Export("performSelecting")]
        void PerformSelecting();
    }

    // @interface FSCalendarEventIndicator : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarEventIndicator
    {
        // @property (assign, nonatomic) NSInteger numberOfEvents;
        [Export("numberOfEvents")]
        nint NumberOfEvents { get; set; }

        // @property (nonatomic, strong) id color;
        [Export("color", ArgumentSemantic.Strong)]
        NSObject Color { get; set; }
    }

    // @interface FSCalendarBlankCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarBlankCell
    {
        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
    }

    // @interface FSCalendarWeekdayView : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarWeekdayView
    {
        // @property (readonly, nonatomic) NSArray<UILabel *> * _Nonnull weekdayLabels;
        [Export("weekdayLabels")]
        UILabel[] WeekdayLabels { get; }

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();

        // @property (readwrite, nonatomic) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Assign)]
        FSCalendar Calendar { get; set; }
    }

    // @interface FSCalendarHeaderView : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarHeaderView
    {
        // @property (nonatomic, weak) FSCalendarCollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Weak)]
        FSCalendarCollectionView CollectionView { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Weak)]
        FSCalendarHeaderLayout CollectionViewLayout { get; set; }

        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (assign, nonatomic) UICollectionViewScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        UICollectionViewScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { get; set; }

        // -(void)setScrollOffset:(CGFloat)scrollOffset;
        [Export("setScrollOffset:")]
        void SetScrollOffset(nfloat scrollOffset);

        // -(void)setScrollOffset:(CGFloat)scrollOffset animated:(BOOL)animated;
        [Export("setScrollOffset:animated:")]
        void SetScrollOffset(nfloat scrollOffset, bool animated);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
    }

    // @interface FSCalendarHeaderCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarHeaderCell
    {
        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderView * header;
        [Export("header", ArgumentSemantic.Weak)]
        FSCalendarHeaderView Header { get; set; }
    }

    // @interface FSCalendarHeaderLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface FSCalendarHeaderLayout
    {
    }

    // @interface FSCalendarHeaderTouchDeliver : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarHeaderTouchDeliver
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderView * header;
        [Export("header", ArgumentSemantic.Weak)]
        FSCalendarHeaderView Header { get; set; }
    }

    //[Static]
    //partial interface Constants
    //{
    //	// extern double FSCalendarVersionNumber;
    //	[Field("FSCalendarVersionNumber", "__Internal")]
    //	double FSCalendarVersionNumber { get; }

    //	// extern const unsigned char [] FSCalendarVersionString;
    //	[Field("FSCalendarVersionString", "__Internal")]
    //	byte[] FSCalendarVersionString { get; }
    //}

    partial interface IFSCalendarDataSource { }

    // @protocol FSCalendarDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDataSource
    {
        // @optional -(NSString * _Nullable)calendar:(FSCalendar * _Nonnull)calendar titleForDate:(NSDate * _Nonnull)date;
        [Export("calendar:titleForDate:")]
        [return: NullAllowed]
        string Calendar_TitleForDate(FSCalendar calendar, NSDate date);

        // @optional -(NSString * _Nullable)calendar:(FSCalendar * _Nonnull)calendar subtitleForDate:(NSDate * _Nonnull)date;
        [Export("calendar:subtitleForDate:")]
        [return: NullAllowed]
        string Calendar_SubtitleForDate(FSCalendar calendar, NSDate date);

        // @optional -(UIImage * _Nullable)calendar:(FSCalendar * _Nonnull)calendar imageForDate:(NSDate * _Nonnull)date;
        [Export("calendar:imageForDate:")]
        [return: NullAllowed]
        UIImage Calendar_ImageForDate(FSCalendar calendar, NSDate date);

        // @optional -(NSDate * _Nonnull)minimumDateForCalendar:(FSCalendar * _Nonnull)calendar;
        [Export("minimumDateForCalendar:")]
        NSDate MinimumDateForCalendar(FSCalendar calendar);

        // @optional -(NSDate * _Nonnull)maximumDateForCalendar:(FSCalendar * _Nonnull)calendar;
        [Export("maximumDateForCalendar:")]
        NSDate MaximumDateForCalendar(FSCalendar calendar);

        // @optional -(__kindof FSCalendarCell * _Nonnull)calendar:(FSCalendar * _Nonnull)calendar cellForDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("calendar:cellForDate:atMonthPosition:")]
        FSCalendarCell Calendar_CellForDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition position);

        // @optional -(NSInteger)calendar:(FSCalendar * _Nonnull)calendar numberOfEventsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:numberOfEventsForDate:")]
        nint Calendar_NumberOfEventsForDate(FSCalendar calendar, NSDate date);
    }

    // @protocol FSCalendarDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDelegate
    {
        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldSelectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:shouldSelectDate:atMonthPosition:")]
        bool CalendarShouldSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didSelectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didSelectDate:atMonthPosition:")]
        void CalendarDidSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:shouldDeselectDate:atMonthPosition:")]
        bool CalendarShouldDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didDeselectDate:atMonthPosition:")]
        void CalendarDidDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar boundingRectWillChange:(CGRect)bounds animated:(BOOL)animated;
        [Export("calendar:boundingRectWillChange:animated:")]
        void CalendarBoundingRectWillChange(FSCalendar calendar, CGRect bounds, bool animated);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar willDisplayCell:(FSCalendarCell * _Nonnull)cell forDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:willDisplayCell:forDate:atMonthPosition:")]
        void CalendarWillDisplayCell(FSCalendar calendar, FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendarCurrentPageDidChange:(FSCalendar * _Nonnull)calendar;
        [Export("calendarCurrentPageDidChange:")]
        void CalendarCurrentPageDidChange(FSCalendar calendar);
    }

    // @protocol FSCalendarDelegateAppearance <FSCalendarDelegate>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDelegateAppearance : FSCalendarDelegate
    {
        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance fillDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:fillDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_FillDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance fillSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:fillSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_FillSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_TitleDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_TitleSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_SubtitleDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_SubtitleSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(NSArray<UIColor *> * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventDefaultColorsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventDefaultColorsForDate:")]
        [return: NullAllowed]
        UIColor[] Calendar_EventDefaultColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(NSArray<UIColor *> * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventSelectionColorsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventSelectionColorsForDate:")]
        [return: NullAllowed]
        UIColor[] Calendar_EventSelectionColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_BorderDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor Calendar_BorderSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleOffsetForDate:")]
        CGPoint Calendar_TitleOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleOffsetForDate:")]
        CGPoint Calendar_SubtitleOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance imageOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:imageOffsetForDate:")]
        CGPoint Calendar_ImageOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventOffsetForDate:")]
        CGPoint Calendar_EventOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGFloat)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderRadiusForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderRadiusForDate:")]
        nfloat Calendar_BorderRadiusForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);
    }

    // @interface FSCalendar : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendar
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        FSCalendarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<FSCalendarDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<FSCalendarDataSource> _Nullable dataSource __attribute__((iboutlet));
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        IFSCalendarDataSource DataSource { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable today;
        [NullAllowed, Export("today", ArgumentSemantic.Strong)]
        NSDate Today { get; set; }

        // @property (nonatomic, strong) NSDate * _Nonnull currentPage;
        [Export("currentPage", ArgumentSemantic.Strong)]
        NSDate CurrentPage { get; set; }

        // @property (copy, nonatomic) NSLocale * _Nonnull locale;
        [Export("locale", ArgumentSemantic.Copy)]
        NSLocale Locale { get; set; }

        // @property (assign, nonatomic) FSCalendarScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        FSCalendarScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) FSCalendarScope scope;
        [Export("scope", ArgumentSemantic.Assign)]
        FSCalendarScope Scope { get; set; }

        // @property (readonly, nonatomic) FSCalendarDeprecated(handleScopeGesture:) UIPanGestureRecognizer * scopeGesture __attribute__((deprecated(" Use handleScopeGesture: instead")));
        [Export("scopeGesture")]
        UIPanGestureRecognizer ScopeGesture { get; }

        // @property (readonly, nonatomic) UILongPressGestureRecognizer * _Nonnull swipeToChooseGesture;
        [Export("swipeToChooseGesture")]
        UILongPressGestureRecognizer SwipeToChooseGesture { get; }

        // @property (assign, nonatomic) FSCalendarPlaceholderType placeholderType;
        [Export("placeholderType", ArgumentSemantic.Assign)]
        FSCalendarPlaceholderType PlaceholderType { get; set; }

        // @property (assign, nonatomic) NSUInteger firstWeekday;
        [Export("firstWeekday")]
        nuint FirstWeekday { get; set; }

        // @property (assign, nonatomic) CGFloat headerHeight;
        [Export("headerHeight")]
        nfloat HeaderHeight { get; set; }

        // @property (assign, nonatomic) CGFloat weekdayHeight;
        [Export("weekdayHeight")]
        nfloat WeekdayHeight { get; set; }

        // @property (nonatomic, strong) FSCalendarWeekdayView * _Nonnull calendarWeekdayView;
        [Export("calendarWeekdayView", ArgumentSemantic.Strong)]
        FSCalendarWeekdayView CalendarWeekdayView { get; set; }

        // @property (nonatomic, strong) FSCalendarHeaderView * _Nonnull calendarHeaderView;
        [Export("calendarHeaderView", ArgumentSemantic.Strong)]
        FSCalendarHeaderView CalendarHeaderView { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelection;
        [Export("allowsSelection")]
        bool AllowsSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) BOOL adjustsBoundingRectWhenChangingMonths;
        [Export("adjustsBoundingRectWhenChangingMonths")]
        bool AdjustsBoundingRectWhenChangingMonths { get; set; }

        // @property (assign, nonatomic) BOOL pagingEnabled;
        [Export("pagingEnabled")]
        bool PagingEnabled { get; set; }

        // @property (assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { get; set; }

        // @property (assign, nonatomic) CGFloat rowHeight;
        [Export("rowHeight")]
        nfloat RowHeight { get; set; }

        // @property (readonly, nonatomic) FSCalendarAppearance * _Nonnull appearance;
        [Export("appearance")]
        FSCalendarAppearance FSAppearance { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull minimumDate;
        [Export("minimumDate")]
        NSDate MinimumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull maximumDate;
        [Export("maximumDate")]
        NSDate MaximumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nullable selectedDate;
        [NullAllowed, Export("selectedDate")]
        NSDate SelectedDate { get; }

        // @property (readonly, nonatomic) NSArray<NSDate *> * _Nonnull selectedDates;
        [Export("selectedDates")]
        NSDate[] SelectedDates { get; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)setScope:(FSCalendarScope)scope animated:(BOOL)animated;
        [Export("setScope:animated:")]
        void SetScope(FSCalendarScope scope, bool animated);

        // -(void)selectDate:(NSDate * _Nullable)date;
        [Export("selectDate:")]
        void SelectDate([NullAllowed] NSDate date);

        // -(void)selectDate:(NSDate * _Nullable)date scrollToDate:(BOOL)scrollToDate;
        [Export("selectDate:scrollToDate:")]
        void SelectDate([NullAllowed] NSDate date, bool scrollToDate);

        // -(void)deselectDate:(NSDate * _Nonnull)date;
        [Export("deselectDate:")]
        void DeselectDate(NSDate date);

        // -(void)setCurrentPage:(NSDate * _Nonnull)currentPage animated:(BOOL)animated;
        [Export("setCurrentPage:animated:")]
        void SetCurrentPage(NSDate currentPage, bool animated);

        // -(void)registerClass:(Class _Nonnull)cellClass forCellReuseIdentifier:(NSString * _Nonnull)identifier;
        [Export("registerClass:forCellReuseIdentifier:")]
        void RegisterClass(Class cellClass, string identifier);

        // -(__kindof FSCalendarCell * _Nonnull)dequeueReusableCellWithIdentifier:(NSString * _Nonnull)identifier forDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("dequeueReusableCellWithIdentifier:forDate:atMonthPosition:")]
        FSCalendarCell DequeueReusableCellWithIdentifier(string identifier, NSDate date, FSCalendarMonthPosition position);

        // -(FSCalendarCell * _Nullable)cellForDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("cellForDate:atMonthPosition:")]
        [return: NullAllowed]
        FSCalendarCell CellForDate(NSDate date, FSCalendarMonthPosition position);

        // -(NSDate * _Nullable)dateForCell:(FSCalendarCell * _Nonnull)cell;
        [Export("dateForCell:")]
        [return: NullAllowed]
        NSDate DateForCell(FSCalendarCell cell);

        // -(FSCalendarMonthPosition)monthPositionForCell:(FSCalendarCell * _Nonnull)cell;
        [Export("monthPositionForCell:")]
        FSCalendarMonthPosition MonthPositionForCell(FSCalendarCell cell);

        // -(NSArray<__kindof FSCalendarCell *> * _Nonnull)visibleCells;
        [Export("visibleCells")]
        FSCalendarCell[] VisibleCells { get; }

        // -(CGRect)frameForDate:(NSDate * _Nonnull)date;
        [Export("frameForDate:")]
        CGRect FrameForDate(NSDate date);

        // -(void)handleScopeGesture:(UIPanGestureRecognizer * _Nonnull)sender;
        [Export("handleScopeGesture:")]
        void HandleScopeGesture(UIPanGestureRecognizer sender);

        // @property (readonly, nonatomic) FSCalendarCollectionView * collectionView;
        [Export("collectionView")]
        FSCalendarCollectionView CollectionView { get; }

        // @property (readonly, nonatomic) FSCalendarCollectionViewLayout * collectionViewLayout;
        [Export("collectionViewLayout")]
        FSCalendarCollectionViewLayout CollectionViewLayout { get; }

        // @property (readonly, nonatomic) FSCalendarTransitionCoordinator * transitionCoordinator;
        [Export("transitionCoordinator")]
        FSCalendarTransitionCoordinator TransitionCoordinator { get; }

        // @property (readonly, nonatomic) FSCalendarCalculator * calculator;
        [Export("calculator")]
        FSCalendarCalculator Calculator { get; }

        // @property (readonly, nonatomic) BOOL floatingMode;
        [Export("floatingMode")]
        bool FloatingMode { get; }

        // @property (readonly, nonatomic) NSArray * visibleStickyHeaders;
        [Export("visibleStickyHeaders")]
        NSObject[] VisibleStickyHeaders { get; }

        // @property (readonly, nonatomic) CGFloat preferredHeaderHeight;
        [Export("preferredHeaderHeight")]
        nfloat PreferredHeaderHeight { get; }

        // @property (readonly, nonatomic) CGFloat preferredWeekdayHeight;
        [Export("preferredWeekdayHeight")]
        nfloat PreferredWeekdayHeight { get; }

        // @property (readonly, nonatomic) UIView * bottomBorder;
        //[Export("bottomBorder")]
        //UIView BottomBorder { get; }
        [Export("bottomBorder")]
        UIView BottomBorder();
        [Export("setBottomBorder:")]
        void SetBottomBorder(UIView bottomBorder);

        // @property (readonly, nonatomic) NSCalendar * gregorian;
        [Export("gregorian")]
        NSCalendar Gregorian { get; }

        // @property (readonly, nonatomic) NSDateFormatter * formatter;
        [Export("formatter")]
        NSDateFormatter Formatter { get; }

        // @property (readonly, nonatomic) UIView * contentView;
        [Export("contentView")]
        UIView ContentView { get; }

        // @property (readonly, nonatomic) UIView * daysContainer;
        [Export("daysContainer")]
        UIView DaysContainer { get; }

        // @property (assign, nonatomic) BOOL needsAdjustingViewFrame;
        [Export("needsAdjustingViewFrame")]
        bool NeedsAdjustingViewFrame { get; set; }

        // -(void)invalidateHeaders;
        [Export("invalidateHeaders")]
        void InvalidateHeaders();

        // -(void)adjustMonthPosition;
        [Export("adjustMonthPosition")]
        void AdjustMonthPosition();

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();

        // -(BOOL)isPageInRange:(NSDate *)page;
        [Export("isPageInRange:")]
        bool IsPageInRange(NSDate page);

        // -(BOOL)isDateInRange:(NSDate *)date;
        [Export("isDateInRange:")]
        bool IsDateInRange(NSDate date);

        // -(CGSize)sizeThatFits:(CGSize)size scope:(FSCalendarScope)scope;
        [Export("sizeThatFits:scope:")]
        CGSize SizeThatFits(CGSize size, FSCalendarScope scope);
    }

    // @interface IBExtension (FSCalendar)
    [Category]
    [BaseType(typeof(FSCalendar))]
    interface FSCalendar_IBExtension
    {
    }

    // @interface FSCalendarCalculator : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarCalculator
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (readonly, nonatomic) NSInteger numberOfSections;
        [Export("numberOfSections")]
        nint NumberOfSections { get; }

        // -(instancetype)initWithCalendar:(FSCalendar *)calendar;
        [Export("initWithCalendar:")]
        IntPtr Constructor(FSCalendar calendar);

        // -(NSDate *)safeDateForDate:(NSDate *)date;
        [Export("safeDateForDate:")]
        NSDate SafeDateForDate(NSDate date);

        // -(NSDate *)dateForIndexPath:(NSIndexPath *)indexPath;
        [Export("dateForIndexPath:")]
        NSDate DateForIndexPath(NSIndexPath indexPath);

        // -(NSDate *)dateForIndexPath:(NSIndexPath *)indexPath scope:(FSCalendarScope)scope;
        [Export("dateForIndexPath:scope:")]
        NSDate DateForIndexPath(NSIndexPath indexPath, FSCalendarScope scope);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date;
        [Export("indexPathForDate:")]
        NSIndexPath IndexPathForDate(NSDate date);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date scope:(FSCalendarScope)scope;
        [Export("indexPathForDate:scope:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarScope scope);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("indexPathForDate:atMonthPosition:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarMonthPosition position);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position scope:(FSCalendarScope)scope;
        [Export("indexPathForDate:atMonthPosition:scope:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarMonthPosition position, FSCalendarScope scope);

        // -(NSDate *)pageForSection:(NSInteger)section;
        [Export("pageForSection:")]
        NSDate PageForSection(nint section);

        // -(NSDate *)weekForSection:(NSInteger)section;
        [Export("weekForSection:")]
        NSDate WeekForSection(nint section);

        // -(NSDate *)monthForSection:(NSInteger)section;
        [Export("monthForSection:")]
        NSDate MonthForSection(nint section);

        // -(NSDate *)monthHeadForSection:(NSInteger)section;
        [Export("monthHeadForSection:")]
        NSDate MonthHeadForSection(nint section);

        // -(NSInteger)numberOfHeadPlaceholdersForMonth:(NSDate *)month;
        [Export("numberOfHeadPlaceholdersForMonth:")]
        nint NumberOfHeadPlaceholdersForMonth(NSDate month);

        // -(NSInteger)numberOfRowsInMonth:(NSDate *)month;
        [Export("numberOfRowsInMonth:")]
        nint NumberOfRowsInMonth(NSDate month);

        // -(NSInteger)numberOfRowsInSection:(NSInteger)section;
        [Export("numberOfRowsInSection:")]
        nint NumberOfRowsInSection(nint section);

        // -(FSCalendarMonthPosition)monthPositionForIndexPath:(NSIndexPath *)indexPath;
        [Export("monthPositionForIndexPath:")]
        FSCalendarMonthPosition MonthPositionForIndexPath(NSIndexPath indexPath);

        // -(FSCalendarCoordinate)coordinateForIndexPath:(NSIndexPath *)indexPath;
        [Export("coordinateForIndexPath:")]
        FSCalendarCoordinate CoordinateForIndexPath(NSIndexPath indexPath);

        // -(void)reloadSections;
        [Export("reloadSections")]
        void ReloadSections();
    }

    // @interface FSCalendarCollectionView : UICollectionView
    [BaseType(typeof(UICollectionView))]
    interface FSCalendarCollectionView
    {
    }

    // @interface FSCalendarCollectionViewLayout : UICollectionViewLayout
    [BaseType(typeof(UICollectionViewLayout))]
    interface FSCalendarCollectionViewLayout
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (assign, nonatomic) CGFloat interitemSpacing;
        [Export("interitemSpacing")]
        nfloat InteritemSpacing { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sectionInsets;
        [Export("sectionInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets SectionInsets { get; set; }

        // @property (assign, nonatomic) UICollectionViewScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        UICollectionViewScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) CGSize headerReferenceSize;
        [Export("headerReferenceSize", ArgumentSemantic.Assign)]
        CGSize HeaderReferenceSize { get; set; }

        // @property (readonly, nonatomic) CGSize estimatedItemSize;
        [Export("estimatedItemSize")]
        CGSize EstimatedItemSize { get; }
    }

    //// @interface FSCalendarDelegationProxy : NSProxy
    //[BaseType(typeof(NSProxy))]
    //interface FSCalendarDelegationProxy
    //{
    //	// @property (nonatomic, weak) id _Nullable delegation;
    //	[NullAllowed, Export("delegation", ArgumentSemantic.Weak)]
    //	NSObject Delegation { get; set; }

    //	// @property (nonatomic, strong) Protocol * _Nonnull protocol;
    //	[Export("protocol", ArgumentSemantic.Strong)]
    //	Protocol Protocol { get; set; }

    //	// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nonnull deprecations;
    //	[Export("deprecations", ArgumentSemantic.Strong)]
    //	NSDictionary<NSString, NSString> Deprecations { get; set; }

    //	// -(SEL _Nonnull)deprecatedSelectorOfSelector:(SEL _Nonnull)selector;
    //	[Export("deprecatedSelectorOfSelector:")]
    //	Selector DeprecatedSelectorOfSelector(Selector selector);
    //}

    //// @interface FSCalendarDelegationFactory : NSObject
    //[BaseType(typeof(NSObject))]
    //interface FSCalendarDelegationFactory
    //{
    //	// +(FSCalendarDelegationProxy *)dataSourceProxy;
    //	[Static]
    //	[Export("dataSourceProxy")]
    //	FSCalendarDelegationProxy DataSourceProxy { get; }

    //	// +(FSCalendarDelegationProxy *)delegateProxy;
    //	[Static]
    //	[Export("delegateProxy")]
    //	FSCalendarDelegationProxy DelegateProxy { get; }
    //}

    // @interface FSCalendarStickyHeader : UICollectionReusableView
    [BaseType(typeof(UICollectionReusableView))]
    interface FSCalendarStickyHeader
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, strong) NSDate * month;
        [Export("month", ArgumentSemantic.Strong)]
        NSDate Month { get; set; }

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
    }

    // @interface FSCalendarTransitionCoordinator : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject))]
    interface FSCalendarTransitionCoordinator : IUIGestureRecognizerDelegate
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarCollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Weak)]
        FSCalendarCollectionView CollectionView { get; set; }

        // @property (nonatomic, weak) FSCalendarCollectionViewLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Weak)]
        FSCalendarCollectionViewLayout CollectionViewLayout { get; set; }

        // @property (assign, nonatomic) FSCalendarTransition transition;
        [Export("transition", ArgumentSemantic.Assign)]
        FSCalendarTransition Transition { get; set; }

        // @property (assign, nonatomic) FSCalendarTransitionState state;
        [Export("state", ArgumentSemantic.Assign)]
        FSCalendarTransitionState State { get; set; }

        // @property (assign, nonatomic) CGSize cachedMonthSize;
        [Export("cachedMonthSize", ArgumentSemantic.Assign)]
        CGSize CachedMonthSize { get; set; }

        // @property (readonly, nonatomic) FSCalendarScope representingScope;
        [Export("representingScope")]
        FSCalendarScope RepresentingScope { get; }

        // -(instancetype)initWithCalendar:(FSCalendar *)calendar;
        [Export("initWithCalendar:")]
        IntPtr Constructor(FSCalendar calendar);

        // -(void)performScopeTransitionFromScope:(FSCalendarScope)fromScope toScope:(FSCalendarScope)toScope animated:(BOOL)animated;
        [Export("performScopeTransitionFromScope:toScope:animated:")]
        void PerformScopeTransitionFromScope(FSCalendarScope fromScope, FSCalendarScope toScope, bool animated);

        // -(void)performBoundingRectTransitionFromMonth:(NSDate *)fromMonth toMonth:(NSDate *)toMonth duration:(CGFloat)duration;
        [Export("performBoundingRectTransitionFromMonth:toMonth:duration:")]
        void PerformBoundingRectTransitionFromMonth(NSDate fromMonth, NSDate toMonth, nfloat duration);

        // -(void)handleScopeGesture:(id)sender;
        [Export("handleScopeGesture:")]
        void HandleScopeGesture(NSObject sender);
    }

    // @interface FSCalendarTransitionAttributes : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarTransitionAttributes
    {
        // @property (assign, nonatomic) CGRect sourceBounds;
        [Export("sourceBounds", ArgumentSemantic.Assign)]
        CGRect SourceBounds { get; set; }

        // @property (assign, nonatomic) CGRect targetBounds;
        [Export("targetBounds", ArgumentSemantic.Assign)]
        CGRect TargetBounds { get; set; }

        // @property (nonatomic, strong) NSDate * sourcePage;
        [Export("sourcePage", ArgumentSemantic.Strong)]
        NSDate SourcePage { get; set; }

        // @property (nonatomic, strong) NSDate * targetPage;
        [Export("targetPage", ArgumentSemantic.Strong)]
        NSDate TargetPage { get; set; }

        // @property (assign, nonatomic) NSInteger focusedRowNumber;
        [Export("focusedRowNumber")]
        nint FocusedRowNumber { get; set; }

        // @property (assign, nonatomic) NSDate * focusedDate;
        [Export("focusedDate", ArgumentSemantic.Assign)]
        NSDate FocusedDate { get; set; }

        // @property (nonatomic, strong) NSDate * firstDayOfMonth;
        [Export("firstDayOfMonth", ArgumentSemantic.Strong)]
        NSDate FirstDayOfMonth { get; set; }
    }

    //// @interface  (FSCalendarDelegationProxy) <FSCalendarDataSource, FSCalendarDelegate, FSCalendarDelegateAppearance>
    //[Category]
    //[BaseType(typeof(FSCalendarDelegationProxy))]
    //interface FSCalendarDelegationProxy_ : IFSCalendarDataSource, IFSCalendarDelegate, IFSCalendarDelegateAppearance
    //{
    //}

    // @interface FSCalendarExtensions (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_FSCalendarExtensions
    {
        // @property (nonatomic) CGFloat fs_width;
        [Export("fs_width")]
        //nfloat Fs_width { get; set; }
        nfloat GetFs_width();
        [Export("setFs_width:")]
        void SetFs_width(nfloat width);

        // @property (nonatomic) CGFloat fs_height;
        [Export("fs_height")]
        //nfloat Fs_height { get; set; }
        nfloat GetFs_height();
        [Export("setFs_height:")]
        void SetFs_height(nfloat height);

        // @property (nonatomic) CGFloat fs_top;
        [Export("fs_top")]
        //nfloat Fs_top { get; set; }
        nfloat GetFs_top();
        [Export("setFs_top:")]
        void SetFs_top(nfloat top);

        // @property (nonatomic) CGFloat fs_left;
        [Export("fs_left")]
        //nfloat Fs_left { get; set; }
        nfloat GetFs_left();
        [Export("SetFs_left:")]
        void SetFs_left(nfloat left);

        // @property (nonatomic) CGFloat fs_bottom;
        [Export("fs_bottom")]
        //nfloat Fs_bottom { get; set; }
        nfloat GetFs_bottom();
        [Export("SetFs_bottom:")]
        void SetFs_bottom(nfloat bottom);

        // @property (nonatomic) CGFloat fs_right;
        [Export("fs_right")]
        //nfloat Fs_right { get; set; }
        nfloat GetFs_right();
        [Export("setFs_right:")]
        void setFs_right(nfloat right);
    }

    // @interface FSCalendarExtensions (CALayer)
    [Category]
    [BaseType(typeof(CALayer))]
    interface CALayer_FSCalendarExtensions
    {
        // @property (nonatomic) CGFloat fs_width;
        [Export("fs_width")]
        //nfloat Fs_width { get; set; }
        nfloat GetFs_width();
        [Export("setFs_width:")]
        void SetFs_width(nfloat width);

        // @property (nonatomic) CGFloat fs_height;
        [Export("fs_height")]
        //nfloat Fs_height { get; set; }
        nfloat GetFs_height();
        [Export("setFs_height:")]
        void SetFs_height(nfloat height);

        // @property (nonatomic) CGFloat fs_top;
        [Export("fs_top")]
        //nfloat Fs_top { get; set; }
        nfloat GetFs_top();
        [Export("setFs_top:")]
        void SetFs_top(nfloat top);

        // @property (nonatomic) CGFloat fs_left;
        [Export("fs_left")]
        //nfloat Fs_left { get; set; }
        nfloat GetFs_left();
        [Export("SetFs_left:")]
        void SetFs_left(nfloat left);

        // @property (nonatomic) CGFloat fs_bottom;
        [Export("fs_bottom")]
        //nfloat Fs_bottom { get; set; }
        nfloat GetFs_bottom();
        [Export("SetFs_bottom:")]
        void SetFs_bottom(nfloat bottom);

        // @property (nonatomic) CGFloat fs_right;
        [Export("fs_right")]
        //nfloat Fs_right { get; set; }
        nfloat GetFs_right();
        [Export("setFs_right:")]
        void setFs_right(nfloat right);
    }

    // @interface FSCalendarExtensions (NSCalendar)
    [Category]
    [BaseType(typeof(NSCalendar))]
    interface NSCalendar_FSCalendarExtensions
    {
        // -(NSDate * _Nullable)fs_firstDayOfMonth:(NSDate * _Nonnull)month;
        [Export("fs_firstDayOfMonth:")]
        [return: NullAllowed]
        NSDate Fs_firstDayOfMonth(NSDate month);

        // -(NSDate * _Nullable)fs_lastDayOfMonth:(NSDate * _Nonnull)month;
        [Export("fs_lastDayOfMonth:")]
        [return: NullAllowed]
        NSDate Fs_lastDayOfMonth(NSDate month);

        // -(NSDate * _Nullable)fs_firstDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_firstDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_firstDayOfWeek(NSDate week);

        // -(NSDate * _Nullable)fs_lastDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_lastDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_lastDayOfWeek(NSDate week);

        // -(NSDate * _Nullable)fs_middleDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_middleDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_middleDayOfWeek(NSDate week);

        // -(NSInteger)fs_numberOfDaysInMonth:(NSDate * _Nonnull)month;
        [Export("fs_numberOfDaysInMonth:")]
        nint Fs_numberOfDaysInMonth(NSDate month);
    }

    //// @interface FSCalendarExtensions (NSMapTable)
    //[Category]
    //[BaseType(typeof(NSMapTable))]
    //interface NSMapTable_FSCalendarExtensions
    //{
    //	// -(void)setObject:(id _Nullable)obj forKeyedSubscript:(id<NSCopying> _Nonnull)key;
    //	[Export("setObject:forKeyedSubscript:")]
    //	void SetObject([NullAllowed] NSObject obj, NSCopying key);

    //	// -(id _Nonnull)objectForKeyedSubscript:(id<NSCopying> _Nonnull)key;
    //	[Export("objectForKeyedSubscript:")]
    //	NSObject ObjectForKeyedSubscript(NSCopying key);
    //}

    // @interface FSCalendarExtensions (NSCache)
    [Category]
    [BaseType(typeof(NSCache))]
    interface NSCache_FSCalendarExtensions
    {
        // -(void)setObject:(id _Nullable)obj forKeyedSubscript:(id<NSCopying> _Nonnull)key;
        [Export("setObject:forKeyedSubscript:")]
        void SetObject([NullAllowed] NSObject obj, NSCopying key);

        // -(id _Nonnull)objectForKeyedSubscript:(id<NSCopying> _Nonnull)key;
        [Export("objectForKeyedSubscript:")]
        NSObject ObjectForKeyedSubscript(NSCopying key);
    }

    // @interface FSCalendarExtensions (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_FSCalendarExtensions
    {
        // -(void)fs_setBoolVariable:(BOOL)value forKey:(NSString * _Nonnull)key;
        [Export("fs_setBoolVariable:forKey:")]
        void Fs_setBoolVariable(bool value, string key);

        // -(BOOL)fs_boolVariableForKey:(NSString * _Nonnull)key;
        [Export("fs_boolVariableForKey:")]
        bool Fs_boolVariableForKey(string key);

        // -(void)fs_setFloatVariable:(CGFloat)value forKey:(NSString * _Nonnull)key;
        [Export("fs_setFloatVariable:forKey:")]
        void Fs_setFloatVariable(nfloat value, string key);

        // -(CGFloat)fs_floatVariableForKey:(NSString * _Nonnull)key;
        [Export("fs_floatVariableForKey:")]
        nfloat Fs_floatVariableForKey(string key);

        // -(void)fs_setIntegerVariable:(NSInteger)value forKey:(NSString * _Nonnull)key;
        [Export("fs_setIntegerVariable:forKey:")]
        void Fs_setIntegerVariable(nint value, string key);

        // -(NSInteger)fs_integerVariableForKey:(NSString * _Nonnull)key;
        [Export("fs_integerVariableForKey:")]
        nint Fs_integerVariableForKey(string key);

        // -(void)fs_setUnsignedIntegerVariable:(NSUInteger)value forKey:(NSString * _Nonnull)key;
        [Export("fs_setUnsignedIntegerVariable:forKey:")]
        void Fs_setUnsignedIntegerVariable(nuint value, string key);

        // -(NSUInteger)fs_unsignedIntegerVariableForKey:(NSString * _Nonnull)key;
        [Export("fs_unsignedIntegerVariableForKey:")]
        nuint Fs_unsignedIntegerVariableForKey(string key);

        // -(void)fs_setVariable:(id _Nonnull)variable forKey:(NSString * _Nonnull)key;
        [Export("fs_setVariable:forKey:")]
        void Fs_setVariable(NSObject variable, string key);

        // -(id _Nonnull)fs_variableForKey:(NSString * _Nonnull)key;
        [Export("fs_variableForKey:")]
        NSObject Fs_variableForKey(string key);

        // -(id _Nullable)fs_performSelector:(SEL _Nonnull)selector withObjects:(id _Nullable)firstObject, ... __attribute__((sentinel(0, 1)));
        [Internal]
        [Export("fs_performSelector:withObjects:", IsVariadic = true)]
        [return: NullAllowed]
        NSObject Fs_performSelector(Selector selector, [NullAllowed] NSObject firstObject, IntPtr varArgs);
    }

    // @interface FSCalendarSeparatorDecorationView : UICollectionReusableView
    [BaseType(typeof(UICollectionReusableView))]
    interface FSCalendarSeparatorDecorationView
    {
    }
}
