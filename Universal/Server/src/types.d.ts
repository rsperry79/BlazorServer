type QueryParameters = { [key: string]: string; };

interface ResponseData<T> {
    d: T;
}

interface Judge {
    Alias: string;
    FirstName: string;
    LastName: string;
    Market: string;
    JudgeID: number;
    Vendor: any;//Vendor;
    Email: string;
    Desc: string;
    JudgeDataXml: string;
    PasswordHash: number[];
    GlobalRole: any; //Roles;
    JudgeProfile: any; //JudgeProfile;
    SuperUserExpiryTime: any; // DateTime;
    SuperUserID: number;
    /** Obsolete */
    IsCrowdSourcingEnabled: boolean;
    IsInternal: boolean;
    AuthType: number;
    AuthUserName: string;
    AuthPUID: string;
    TeamID: number;
    TeamName: string;
    ExpireAt: any; //DateTime;
    IsExpired: boolean;
}

interface HitPackageArray extends Array<HitPackage> {
    startTime?: Date;
}

interface HitPackage {
    SatelliteID: number;
    TaskGroupID: number;
    HitGroupID: number;
    HitID: number;
    JudgmentID: number;
    HitGroupDataXML: string;
    HitGroupDataInt: number;
    HitDataXML: string;
    HitDataInt: number;
    JudgmentDataXML: string;
    JudgmentDataInt: number;
    TimeSpentOnJudgment: number;
    FinishedJudgmentData: any[]; //JudgmentData[];
    RealTimeAudit: RealTimeAudit;
    LeasedCount: number;
    IsGoldHit: boolean;
    HitType: any; //HitType;
    PreviewOnly: boolean;
    ReputationScore: number;
    Price: number;
    LeaseTime: number;
    isCrowdSourcing: boolean;
    LeaseExpireTime: any; //DateTime;
    PropertyBag: { Key: string, Value: string | number }[]; // Dictionary<string,string>
    SuggestedGoldHitTypeID: number;
    ServerDetails: SerializedInfo;
    IsBouncy: boolean;

    // Backend fields.
    hitData?: {};
}

interface HitPackageList {
    HitPackages: HitPackage[];

    MissingHitsReason: number; // MissingHitsReason

    MissingHitsReasonText: string | null;
}

interface AspectInfo {
    AspectId: number;
    Name: string;
    Properties: string[];
    SnapshotScript?: string;
    SnapshotTemplate?: string;
    HiddenProperties: string[];
}

interface AspectDataWithAgreement {
    Info: AspectInfo;
    IsCorrect?: boolean;
    OffBy?: number;
}

interface SerializedInfo {
    /** Version, used by server to handle multiple variants of the serialization at a time (e.g. to support backwards compat during deployment) */
    Version: number;

    /** The serialized message. */
    Message: string;
}

interface AuditReview {
    HitJudgeAuditID: number;
    JudgeID: number;
    HitAppID: number;
    JudgeGroupID: number;
    AuditHitID: number;
    HitPackage: HitPackage;
}

interface RTAAudit {
    HitAppID: number;
    JudgeGroupID: number;
    JudgeGroupName: string;
    VendorID: number;
    VendorName: string;
    RTAID: number;
    AuditorState: any; //AuditorState;
    VMState: any; //VMState;
    MSFTState: any; //MSFTState;
    RTARating: number;
    LatestComment: string;
    LatestAspectComments: { Key: number, Value: string }[];
    HitPackage: HitPackage;
    LatestReviewer: number;
    LatestReviewerName: string;
    NominatedBy: number;
    NominatedByName: string;
    NominatedAt: Date;
    DisagreementSeverity: number;
    AuditorRatings: string;
    JudgmentRatings: string;
    NewAssignRequest: string;
    LatestQualityComment: string;
    QualityComments: string;
    NominationTime: Date;
    VendorApproveTime: Date;
    MSFTApproveTime: Date;
    CurAuditorType: any; //AuditorType;
    GoldHitTypeID: any; //GoldHitType;
    TaskID: number;
    TaskGroupID: number;
    ReachedConsensus: boolean;
    AuditHitId: number;
    JudgmentHistoryJson: string;
    GoldHitStatus: string;
}

interface Audit {
    HitAuditorAuditID: number;
    HitAuditorFeedbackID: number;
    HitAppID: number;
    JudgeGroupID: number;
    AuditHitID: number;
    HitPackage: HitPackage;
    AuditHistory: any[]; //AuditEvent[];
    Status: any; //AuditStatus;
    DisagreementSeverity: number;
    RTAInfo: any; //RTAInfo;
}

interface DirectGoldHitAudit {
    judgmentHistory: JudgmentHistoryInfo[];
    readOnly: boolean;
}

interface JudgmentHistoryInfo {
    JudgeId: number;
    JudgeName: string;
    Timestamp: string;
    Rating: string;
    JudgmentId: number;
    Comment: string;
    AspectComments: {[AspectId: number]: string};
    IsHighQuality: boolean;
    JudgmentType: string;
    JXmlDictionary: {[XMLProperty: string]: string};
    TaskGroupId: number;
    IsAppealActionValid: boolean;
    AppealState: string;
    JudgmentDataInt?: number;
}

interface AuditOrRTAAudit extends Audit, RTAAudit {
    // Workaround for judgeController code - this is either one or another, not both at the same time.
}

declare enum HowClose {
    Correct = 0,
    Close = 1,
    Wrong = 2
}

declare enum RealTimeAuditAppealType {
    None = 0,
    SaveAudit = 1,
    /** Original appealable RTA -- get user feedback when they see the comment */
    AppealAudit = 2,
    /** Save comment, but before seeing gold feedback */
    SaveAuditPreComment = 3
}

interface AspectRealTimeAudit {
    DoAgree?: boolean;
    OffBy?: number;
}

interface RealTimeAudit {
    /** If true, then the ratings are not displayed on the RTA dialogue. */
    HideRatings: boolean;

    /** The official rating. */
    OfficialRating: number;

    /** The comment giving reason for the rating. */
    OfficialComment?: string;

    /** The comment giving reason for the aspect value. */
    OfficialAspectComments?: { Key: number, Value: string }[];

    /** Comment by the judge. */
    JudgeComment?: string;

    RealTimeAuditAppealType: RealTimeAuditAppealType;

    AppealedAspectIDToComment?: { Key: number, Value: string }[];

    SatelliteID: number;

    JudgmentID: number;

    /** time spent on judgment in milliseconds */
    TimeSpentOnJudgment?: number;

    /** Defines if user was correct, close, or wrong */
    Closeness: HowClose;

    JXmlDictionary: { Key: string, Value: string }[]; // Dictionary<string,string>

    AspectCorrectness?: {Key: number, Value: AspectRealTimeAudit}[];

    IsIncorrectOnHiddenAspect: boolean;
}

interface HitAppInfo {
    HitAppID: number;
    HitAppName: string;
    GoldHitCreationTaskGroupID: number;
    Desc: string;
    NoOfHitsAvailable: number;
    Market: string;
    HasAudits: boolean;
    IsAddedInFavList: boolean;
    EntryURL: string;
    Priority: number;
    IsCrowdSourcing: boolean;
    NeedConsent: boolean;
    IsHappy: boolean;
    IsInQualificationTest: boolean;
    IsQualificationTestNeeded: boolean;
    IsQualificationTaskAvailable: boolean;
    LastQualificationTestStatus: any; // QualificationTestStatus;
    NoOfQualificationAttemptsDone: number;
    QualificationTestMaxAttempt: number;
    QualificationTestNumberOfHits: number;
    HasGuideline: boolean;
    HasReadTheGuideline: boolean;
    IsGuidelineReadingMandatory: boolean;
    ApplicationDataXmlConfiguration: any; // ApplicationDataXmlConfiguration;
    IsPreviewTaskAvailable: boolean;
    IsTrainingTaskAvailable: boolean;
    NumberOfFeedbackAvailable: number;
    IsGoldHitCreationTaskAvailable: boolean;
    IsReviewTaskAvailable: boolean;
    NoOfReviewHitsAvailable: number;
    IsRTAReviewSupported: boolean;
    JudgePaymentRate: number;
    JudgmentRate: number;
    ExperimentTypeID: number;
    ExperimentName: string;
    PHIncentiveHits: number;
    PHIncentivePayment: number;
    PHIncentiveSpamScore: number;
    PHIncentiveStartDate: string;
    PHIncentiveEffectiveEndDate: string;
    PHIncentiveMax: number;
    RaffleIncentiveHits: number;
    RaffleIncentivePayment: number;
    RaffleIncentiveSpamScore: number;
    RaffleIncentiveMaxEntries: number;
    RaffleIncentiveStartDate: string;
    RaffleIncentiveEffectiveEndDate: string;
    HasJudgeSpamStats: boolean;
    HitsPerPage: number;
    PropertyBag: { Key: string, Value: string }[]; // Dictionary<string,string>;
    JHQS: string;
    MaxQSPromAttempts: number;
    NumQSPromLeft: number;
    NumHitsQSProm: number
}


interface HitAppJudgingData {
    AppXml: string,
    Market: string,
    ApplicationID: number,
    Aspects: AspectInfo[],
    HitAppName: string,
    FriendlyHitAppName: string,
    MaxHitsPerPack: number,
    User: UserInfo,
}


interface UserInfo {
    Id: number,
    FirstName: string,
    LastName: string,
    Alias: string,
}

/**
 * Marketplasce window only.
 */
//interface Window {
//    xServer?: xServer;
//    feedbackDialog?: FeedbackDialog;
//}