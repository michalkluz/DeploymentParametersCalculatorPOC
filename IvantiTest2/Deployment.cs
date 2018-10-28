using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IvantiTest2
{
    public partial class AllDeployments
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("value")]
        public Deployment[] Deployment { get; set; }
    }

    public partial class Deployment
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("release")]
        public ReleaseClass Release { get; set; }

        [JsonProperty("releaseDefinition")]
        public ReleaseDefinition ReleaseDefinition { get; set; }

        [JsonProperty("releaseEnvironment")]
        public PurpleRelease ReleaseEnvironment { get; set; }

        [JsonProperty("definitionEnvironmentId")]
        public long DefinitionEnvironmentId { get; set; }

        [JsonProperty("attempt")]
        public long Attempt { get; set; }

        [JsonProperty("reason")]
        public ValueReason Reason { get; set; }

        [JsonProperty("deploymentStatus")]
        public DeploymentStatus DeploymentStatus { get; set; }

        [JsonProperty("operationStatus")]
        public OperationStatus OperationStatus { get; set; }

        [JsonProperty("requestedBy")]
        public RequestedBy RequestedBy { get; set; }

        [JsonProperty("requestedFor")]
        public RequestedBy RequestedFor { get; set; }

        [JsonProperty("queuedOn")]
        public DateTimeOffset QueuedOn { get; set; }

        [JsonProperty("startedOn")]
        public DateTimeOffset StartedOn { get; set; }

        [JsonProperty("lastModifiedOn")]
        public DateTimeOffset LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy")]
        public RequestedBy LastModifiedBy { get; set; }

        [JsonProperty("conditions")]
        public Condition[] Conditions { get; set; }

        [JsonProperty("scheduledDeploymentTime")]
        public DateTimeOffset ScheduledDeploymentTime { get; set; }

        [JsonProperty("preDeployApprovals")]
        public DeployApproval[] PreDeployApprovals { get; set; }

        [JsonProperty("postDeployApprovals")]
        public DeployApproval[] PostDeployApprovals { get; set; }

        [JsonProperty("_links")]
        public ValueLinks Links { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("conditionType")]
        public ConditionType ConditionType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class RequestedBy
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("displayName")]
        public DisplayName DisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }
    }

    public partial class ValueLinks
    {
    }

    public partial class DeployApproval
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("approvalType")]
        public ApprovalType ApprovalType { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTimeOffset ModifiedOn { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("isAutomated")]
        public bool IsAutomated { get; set; }

        [JsonProperty("isNotificationOn")]
        public bool IsNotificationOn { get; set; }

        [JsonProperty("trialNumber")]
        public long TrialNumber { get; set; }

        [JsonProperty("attempt")]
        public long Attempt { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("release")]
        public PurpleRelease Release { get; set; }

        [JsonProperty("releaseDefinition")]
        public PurpleRelease ReleaseDefinition { get; set; }

        [JsonProperty("releaseEnvironment")]
        public PurpleRelease ReleaseEnvironment { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public RequestedBy Approver { get; set; }

        [JsonProperty("approvedBy", NullValueHandling = NullValueHandling.Ignore)]
        public RequestedBy ApprovedBy { get; set; }
    }

    public partial class PurpleRelease
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public ValueLinks Links { get; set; }
    }

    public partial class ReleaseClass
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("artifacts")]
        public Artifact[] Artifacts { get; set; }

        [JsonProperty("webAccessUri")]
        public Uri WebAccessUri { get; set; }

        [JsonProperty("_links")]
        public PurpleLinks Links { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("releaseDefinition")]
        public object ReleaseDefinition { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public object CreatedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public object ModifiedBy { get; set; }

        [JsonProperty("reason")]
        public ReleaseReason Reason { get; set; }
    }

    public partial class Artifact
    {
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alias")]
        public Alias Alias { get; set; }

        [JsonProperty("definitionReference")]
        public DefinitionReference DefinitionReference { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public partial class DefinitionReference
    {
        [JsonProperty("artifactSourceDefinitionUrl")]
        public ArtifactSourceDefinitionUrl ArtifactSourceDefinitionUrl { get; set; }

        [JsonProperty("defaultVersionBranch")]
        public ArtifactSourceDefinitionUrl DefaultVersionBranch { get; set; }

        [JsonProperty("defaultVersionSpecific")]
        public ArtifactSourceDefinitionUrl DefaultVersionSpecific { get; set; }

        [JsonProperty("defaultVersionTags")]
        public ArtifactSourceDefinitionUrl DefaultVersionTags { get; set; }

        [JsonProperty("defaultVersionType")]
        public ArtifactSourceDefinitionUrl DefaultVersionType { get; set; }

        [JsonProperty("definition")]
        public ArtifactSourceDefinitionUrl Definition { get; set; }

        [JsonProperty("project")]
        public ArtifactSourceDefinitionUrl Project { get; set; }

        [JsonProperty("version")]
        public ArtifactSourceDefinitionUrl Version { get; set; }

        [JsonProperty("artifactSourceVersionUrl")]
        public ArtifactSourceDefinitionUrl ArtifactSourceVersionUrl { get; set; }

        [JsonProperty("branch")]
        public ArtifactSourceDefinitionUrl Branch { get; set; }
    }

    public partial class ArtifactSourceDefinitionUrl
    {
        [JsonProperty("id")]
        public IdUnion Id { get; set; }

        [JsonProperty("name")]
        public NameUnion Name { get; set; }
    }

    public partial class PurpleLinks
    {
        [JsonProperty("self")]
        public Self Self { get; set; }

        [JsonProperty("web")]
        public Self Web { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class ReleaseDefinition
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public NameEnum Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public PurpleLinks Links { get; set; }
    }

    public enum ConditionType { EnvironmentState, Event };

    public enum DeploymentStatus { NotDeployed, Succeeded };

    public enum DisplayName { ChuckReinhart, MicrosoftVisualStudioServicesReleaseManagement };

    public enum OperationStatus { Approved, PhaseFailed };

    public enum ApprovalType { PostDeploy, PreDeploy };

    public enum Comments { Empty, GoodToGo };

    public enum Status { Approved };

    public enum ValueReason { Automated, Manual };

    public enum Alias { Empty, FabrikamCi, Latest, MyFirstProject, RefsHeadsMaster };

    public enum IdEnum { Empty, LatestType, RefsHeadsMaster };

    public enum ReleaseReason { None };

    public enum NameEnum { FabrikamWeb, MyShuttleCd };

    public partial struct IdUnion
    {
        public IdEnum? Enum;
        public long? Integer;
        public Uri PurpleUri;
        public Guid? Uuid;

        public static implicit operator IdUnion(IdEnum Enum) => new IdUnion { Enum = Enum };
        public static implicit operator IdUnion(long Integer) => new IdUnion { Integer = Integer };
        public static implicit operator IdUnion(Uri PurpleUri) => new IdUnion { PurpleUri = PurpleUri };
        public static implicit operator IdUnion(Guid Uuid) => new IdUnion { Uuid = Uuid };
    }

    public partial struct NameUnion
    {
        public Alias? Enum;
        public long? Integer;

        public static implicit operator NameUnion(Alias Enum) => new NameUnion { Enum = Enum };
        public static implicit operator NameUnion(long Integer) => new NameUnion { Integer = Integer };
    }

    public partial class AllDeployments
    {
        public static AllDeployments FromJson(string json) => JsonConvert.DeserializeObject<AllDeployments>(json, IvantiTest2.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AllDeployments self) => JsonConvert.SerializeObject(self, IvantiTest2.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                ConditionTypeConverter.Singleton,
                DeploymentStatusConverter.Singleton,
                DisplayNameConverter.Singleton,
                OperationStatusConverter.Singleton,
                ApprovalTypeConverter.Singleton,
                CommentsConverter.Singleton,
                StatusConverter.Singleton,
                ValueReasonConverter.Singleton,
                AliasConverter.Singleton,
                IdUnionConverter.Singleton,
                IdEnumConverter.Singleton,
                NameUnionConverter.Singleton,
                ReleaseReasonConverter.Singleton,
                NameEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ConditionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionType) || t == typeof(ConditionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "environmentState":
                    return ConditionType.EnvironmentState;
                case "event":
                    return ConditionType.Event;
            }
            throw new Exception("Cannot unmarshal type ConditionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ConditionType)untypedValue;
            switch (value)
            {
                case ConditionType.EnvironmentState:
                    serializer.Serialize(writer, "environmentState");
                    return;
                case ConditionType.Event:
                    serializer.Serialize(writer, "event");
                    return;
            }
            throw new Exception("Cannot marshal type ConditionType");
        }

        public static readonly ConditionTypeConverter Singleton = new ConditionTypeConverter();
    }

    internal class DeploymentStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DeploymentStatus) || t == typeof(DeploymentStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "notDeployed":
                    return DeploymentStatus.NotDeployed;
                case "succeeded":
                    return DeploymentStatus.Succeeded;
            }
            throw new Exception("Cannot unmarshal type DeploymentStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DeploymentStatus)untypedValue;
            switch (value)
            {
                case DeploymentStatus.NotDeployed:
                    serializer.Serialize(writer, "notDeployed");
                    return;
                case DeploymentStatus.Succeeded:
                    serializer.Serialize(writer, "succeeded");
                    return;
            }
            throw new Exception("Cannot marshal type DeploymentStatus");
        }

        public static readonly DeploymentStatusConverter Singleton = new DeploymentStatusConverter();
    }

    internal class DisplayNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DisplayName) || t == typeof(DisplayName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Chuck Reinhart":
                    return DisplayName.ChuckReinhart;
                case "Microsoft.VisualStudio.Services.ReleaseManagement":
                    return DisplayName.MicrosoftVisualStudioServicesReleaseManagement;
            }
            throw new Exception("Cannot unmarshal type DisplayName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DisplayName)untypedValue;
            switch (value)
            {
                case DisplayName.ChuckReinhart:
                    serializer.Serialize(writer, "Chuck Reinhart");
                    return;
                case DisplayName.MicrosoftVisualStudioServicesReleaseManagement:
                    serializer.Serialize(writer, "Microsoft.VisualStudio.Services.ReleaseManagement");
                    return;
            }
            throw new Exception("Cannot marshal type DisplayName");
        }

        public static readonly DisplayNameConverter Singleton = new DisplayNameConverter();
    }

    internal class OperationStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OperationStatus) || t == typeof(OperationStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Approved":
                    return OperationStatus.Approved;
                case "PhaseFailed":
                    return OperationStatus.PhaseFailed;
            }
            throw new Exception("Cannot unmarshal type OperationStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OperationStatus)untypedValue;
            switch (value)
            {
                case OperationStatus.Approved:
                    serializer.Serialize(writer, "Approved");
                    return;
                case OperationStatus.PhaseFailed:
                    serializer.Serialize(writer, "PhaseFailed");
                    return;
            }
            throw new Exception("Cannot marshal type OperationStatus");
        }

        public static readonly OperationStatusConverter Singleton = new OperationStatusConverter();
    }

    internal class ApprovalTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ApprovalType) || t == typeof(ApprovalType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "postDeploy":
                    return ApprovalType.PostDeploy;
                case "preDeploy":
                    return ApprovalType.PreDeploy;
            }
            throw new Exception("Cannot unmarshal type ApprovalType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ApprovalType)untypedValue;
            switch (value)
            {
                case ApprovalType.PostDeploy:
                    serializer.Serialize(writer, "postDeploy");
                    return;
                case ApprovalType.PreDeploy:
                    serializer.Serialize(writer, "preDeploy");
                    return;
            }
            throw new Exception("Cannot marshal type ApprovalType");
        }

        public static readonly ApprovalTypeConverter Singleton = new ApprovalTypeConverter();
    }

    internal class CommentsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Comments) || t == typeof(Comments?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Comments.Empty;
                case "Good to go!":
                    return Comments.GoodToGo;
            }
            throw new Exception("Cannot unmarshal type Comments");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Comments)untypedValue;
            switch (value)
            {
                case Comments.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Comments.GoodToGo:
                    serializer.Serialize(writer, "Good to go!");
                    return;
            }
            throw new Exception("Cannot marshal type Comments");
        }

        public static readonly CommentsConverter Singleton = new CommentsConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "approved")
            {
                return Status.Approved;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Approved)
            {
                serializer.Serialize(writer, "approved");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class ValueReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueReason) || t == typeof(ValueReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "automated":
                    return ValueReason.Automated;
                case "manual":
                    return ValueReason.Manual;
            }
            throw new Exception("Cannot unmarshal type ValueReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValueReason)untypedValue;
            switch (value)
            {
                case ValueReason.Automated:
                    serializer.Serialize(writer, "automated");
                    return;
                case ValueReason.Manual:
                    serializer.Serialize(writer, "manual");
                    return;
            }
            throw new Exception("Cannot marshal type ValueReason");
        }

        public static readonly ValueReasonConverter Singleton = new ValueReasonConverter();
    }

    internal class AliasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Alias) || t == typeof(Alias?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Alias.Empty;
                case "Fabrikam.CI":
                    return Alias.FabrikamCi;
                case "Latest":
                    return Alias.Latest;
                case "MyFirstProject":
                    return Alias.MyFirstProject;
                case "refs/heads/master":
                    return Alias.RefsHeadsMaster;
            }
            throw new Exception("Cannot unmarshal type Alias");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Alias)untypedValue;
            switch (value)
            {
                case Alias.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Alias.FabrikamCi:
                    serializer.Serialize(writer, "Fabrikam.CI");
                    return;
                case Alias.Latest:
                    serializer.Serialize(writer, "Latest");
                    return;
                case Alias.MyFirstProject:
                    serializer.Serialize(writer, "MyFirstProject");
                    return;
                case Alias.RefsHeadsMaster:
                    serializer.Serialize(writer, "refs/heads/master");
                    return;
            }
            throw new Exception("Cannot marshal type Alias");
        }

        public static readonly AliasConverter Singleton = new AliasConverter();
    }

    internal class IdUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IdUnion) || t == typeof(IdUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "":
                            return new IdUnion { Enum = IdEnum.Empty };
                        case "latestType":
                            return new IdUnion { Enum = IdEnum.LatestType };
                        case "refs/heads/master":
                            return new IdUnion { Enum = IdEnum.RefsHeadsMaster };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new IdUnion { Integer = l };
                    }
                    try
                    {
                        var uri = new Uri(stringValue);
                        return new IdUnion { PurpleUri = uri };
                    }
                    catch (UriFormatException) { }
                    Guid guid;
                    if (Guid.TryParse(stringValue, out guid))
                    {
                        return new IdUnion { Uuid = guid };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type IdUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (IdUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case IdEnum.Empty:
                        serializer.Serialize(writer, "");
                        return;
                    case IdEnum.LatestType:
                        serializer.Serialize(writer, "latestType");
                        return;
                    case IdEnum.RefsHeadsMaster:
                        serializer.Serialize(writer, "refs/heads/master");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            if (value.PurpleUri != null)
            {
                serializer.Serialize(writer, value.PurpleUri.ToString());
                return;
            }
            if (value.Uuid != null)
            {
                serializer.Serialize(writer, value.Uuid.Value.ToString("D", System.Globalization.CultureInfo.InvariantCulture));
                return;
            }
            throw new Exception("Cannot marshal type IdUnion");
        }

        public static readonly IdUnionConverter Singleton = new IdUnionConverter();
    }

    internal class IdEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IdEnum) || t == typeof(IdEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return IdEnum.Empty;
                case "latestType":
                    return IdEnum.LatestType;
                case "refs/heads/master":
                    return IdEnum.RefsHeadsMaster;
            }
            throw new Exception("Cannot unmarshal type IdEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IdEnum)untypedValue;
            switch (value)
            {
                case IdEnum.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case IdEnum.LatestType:
                    serializer.Serialize(writer, "latestType");
                    return;
                case IdEnum.RefsHeadsMaster:
                    serializer.Serialize(writer, "refs/heads/master");
                    return;
            }
            throw new Exception("Cannot marshal type IdEnum");
        }

        public static readonly IdEnumConverter Singleton = new IdEnumConverter();
    }

    internal class NameUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameUnion) || t == typeof(NameUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "":
                            return new NameUnion { Enum = Alias.Empty };
                        case "Fabrikam.CI":
                            return new NameUnion { Enum = Alias.FabrikamCi };
                        case "Latest":
                            return new NameUnion { Enum = Alias.Latest };
                        case "MyFirstProject":
                            return new NameUnion { Enum = Alias.MyFirstProject };
                        case "refs/heads/master":
                            return new NameUnion { Enum = Alias.RefsHeadsMaster };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new NameUnion { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type NameUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (NameUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Alias.Empty:
                        serializer.Serialize(writer, "");
                        return;
                    case Alias.FabrikamCi:
                        serializer.Serialize(writer, "Fabrikam.CI");
                        return;
                    case Alias.Latest:
                        serializer.Serialize(writer, "Latest");
                        return;
                    case Alias.MyFirstProject:
                        serializer.Serialize(writer, "MyFirstProject");
                        return;
                    case Alias.RefsHeadsMaster:
                        serializer.Serialize(writer, "refs/heads/master");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type NameUnion");
        }

        public static readonly NameUnionConverter Singleton = new NameUnionConverter();
    }

    internal class ReleaseReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReleaseReason) || t == typeof(ReleaseReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "none")
            {
                return ReleaseReason.None;
            }
            throw new Exception("Cannot unmarshal type ReleaseReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ReleaseReason)untypedValue;
            if (value == ReleaseReason.None)
            {
                serializer.Serialize(writer, "none");
                return;
            }
            throw new Exception("Cannot marshal type ReleaseReason");
        }

        public static readonly ReleaseReasonConverter Singleton = new ReleaseReasonConverter();
    }

    internal class NameEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameEnum) || t == typeof(NameEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Fabrikam-web":
                    return NameEnum.FabrikamWeb;
                case "MyShuttle.CD":
                    return NameEnum.MyShuttleCd;
            }
            throw new Exception("Cannot unmarshal type NameEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NameEnum)untypedValue;
            switch (value)
            {
                case NameEnum.FabrikamWeb:
                    serializer.Serialize(writer, "Fabrikam-web");
                    return;
                case NameEnum.MyShuttleCd:
                    serializer.Serialize(writer, "MyShuttle.CD");
                    return;
            }
            throw new Exception("Cannot marshal type NameEnum");
        }

        public static readonly NameEnumConverter Singleton = new NameEnumConverter();
    }
}

