using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AwsConsole
{
    
    public partial class Aws
    {
        [JsonProperty("Reservations")]
        public Reservation[] Reservations { get; set; }
    }

    public partial class Reservation
    {
        [JsonProperty("Groups")]
        public object[] Groups { get; set; }

        [JsonProperty("Instances")]
        public Instance[] Instances { get; set; }

        [JsonProperty("OwnerId")]
        public string OwnerId { get; set; }

        [JsonProperty("ReservationId")]
        public string ReservationId { get; set; }

        [JsonProperty("RequesterId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequesterId { get; set; }
    }

    public partial class Instance
    {
        [JsonProperty("AmiLaunchIndex")]
        public long AmiLaunchIndex { get; set; }

        [JsonProperty("ImageId")]
        public string ImageId { get; set; }

        [JsonProperty("InstanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("InstanceType")]
        public InstanceType InstanceType { get; set; }

        [JsonProperty("LaunchTime")]
        public DateTimeOffset LaunchTime { get; set; }

        [JsonProperty("Monitoring")]
        public Monitoring Monitoring { get; set; }

        [JsonProperty("Placement")]
        public Placement Placement { get; set; }

        [JsonProperty("Platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("PrivateDnsName")]
        public string PrivateDnsName { get; set; }

        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress { get; set; }

        [JsonProperty("ProductCodes")]
        public ProductCode[] ProductCodes { get; set; }

        [JsonProperty("PublicDnsName")]
        public string PublicDnsName { get; set; }

        [JsonProperty("State")]
        public StateClass State { get; set; }

        [JsonProperty("StateTransitionReason")]
        public StateTransitionReason StateTransitionReason { get; set; }

        [JsonProperty("SubnetId")]
        public SubnetId SubnetId { get; set; }

        [JsonProperty("VpcId")]
        public VpcId VpcId { get; set; }

        [JsonProperty("Architecture")]
        public Architecture Architecture { get; set; }

        [JsonProperty("BlockDeviceMappings")]
        public BlockDeviceMapping[] BlockDeviceMappings { get; set; }

        [JsonProperty("ClientToken")]
        public ClientTokenUnion ClientToken { get; set; }

        [JsonProperty("EbsOptimized")]
        public bool EbsOptimized { get; set; }

        [JsonProperty("EnaSupport")]
        public bool EnaSupport { get; set; }

        [JsonProperty("Hypervisor")]
        public Hypervisor Hypervisor { get; set; }

        [JsonProperty("IamInstanceProfile", NullValueHandling = NullValueHandling.Ignore)]
        public IamInstanceProfile IamInstanceProfile { get; set; }

        [JsonProperty("NetworkInterfaces")]
        public NetworkInterface[] NetworkInterfaces { get; set; }

        [JsonProperty("RootDeviceName")]
        public DeviceName RootDeviceName { get; set; }

        [JsonProperty("RootDeviceType")]
        public RootDeviceType RootDeviceType { get; set; }

        [JsonProperty("SecurityGroups")]
        public Group[] SecurityGroups { get; set; }

        [JsonProperty("SourceDestCheck")]
        public bool SourceDestCheck { get; set; }

        [JsonProperty("Tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("VirtualizationType")]
        public VirtualizationType VirtualizationType { get; set; }

        [JsonProperty("CpuOptions")]
        public CpuOptions CpuOptions { get; set; }

        [JsonProperty("CapacityReservationSpecification")]
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        [JsonProperty("HibernationOptions")]
        public HibernationOptions HibernationOptions { get; set; }

        [JsonProperty("StateReason", NullValueHandling = NullValueHandling.Ignore)]
        public StateReason StateReason { get; set; }
    }

    public partial class BlockDeviceMapping
    {
        [JsonProperty("DeviceName")]
        public DeviceName DeviceName { get; set; }

        [JsonProperty("Ebs")]
        public Ebs Ebs { get; set; }
    }

    public partial class Ebs
    {
        [JsonProperty("AttachTime")]
        public DateTimeOffset AttachTime { get; set; }

        [JsonProperty("DeleteOnTermination")]
        public bool DeleteOnTermination { get; set; }

        [JsonProperty("Status")]
        public EbsStatus Status { get; set; }

        [JsonProperty("VolumeId")]
        public string VolumeId { get; set; }
    }

    public partial class CapacityReservationSpecification
    {
        [JsonProperty("CapacityReservationPreference")]
        public CapacityReservationPreference CapacityReservationPreference { get; set; }
    }

    public partial class CpuOptions
    {
        [JsonProperty("CoreCount")]
        public long CoreCount { get; set; }

        [JsonProperty("ThreadsPerCore")]
        public long ThreadsPerCore { get; set; }
    }

    public partial class HibernationOptions
    {
        [JsonProperty("Configured")]
        public bool Configured { get; set; }
    }

    public partial class IamInstanceProfile
    {
        [JsonProperty("Arn")]
        public string Arn { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }
    }

    public partial class Monitoring
    {
        [JsonProperty("State")]
        public StateEnum State { get; set; }
    }

    public partial class NetworkInterface
    {
        [JsonProperty("Attachment")]
        public Attachment Attachment { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("Groups")]
        public Group[] Groups { get; set; }

        [JsonProperty("Ipv6Addresses")]
        public object[] Ipv6Addresses { get; set; }

        [JsonProperty("MacAddress")]
        public string MacAddress { get; set; }

        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId { get; set; }

        [JsonProperty("OwnerId")]
        public string OwnerId { get; set; }

        [JsonProperty("PrivateDnsName")]
        public string PrivateDnsName { get; set; }

        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress { get; set; }

        [JsonProperty("PrivateIpAddresses")]
        public PrivateIpAddress[] PrivateIpAddresses { get; set; }

        [JsonProperty("SourceDestCheck")]
        public bool SourceDestCheck { get; set; }

        [JsonProperty("Status")]
        public NetworkInterfaceStatus Status { get; set; }

        [JsonProperty("SubnetId")]
        public SubnetId SubnetId { get; set; }

        [JsonProperty("VpcId")]
        public VpcId VpcId { get; set; }
    }

    public partial class Attachment
    {
        [JsonProperty("AttachTime")]
        public DateTimeOffset AttachTime { get; set; }

        [JsonProperty("AttachmentId")]
        public string AttachmentId { get; set; }

        [JsonProperty("DeleteOnTermination")]
        public bool DeleteOnTermination { get; set; }

        [JsonProperty("DeviceIndex")]
        public long DeviceIndex { get; set; }

        [JsonProperty("Status")]
        public EbsStatus Status { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("GroupName")]
        public Tenancy GroupName { get; set; }

        [JsonProperty("GroupId")]
        public GroupId GroupId { get; set; }
    }

    public partial class PrivateIpAddress
    {
        [JsonProperty("Primary")]
        public bool Primary { get; set; }

        [JsonProperty("PrivateDnsName")]
        public string PrivateDnsName { get; set; }

        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddressPrivateIpAddress { get; set; }
    }

    public partial class Placement
    {
        [JsonProperty("AvailabilityZone")]
        public AvailabilityZone AvailabilityZone { get; set; }

        [JsonProperty("GroupName")]
        public string GroupName { get; set; }

        [JsonProperty("Tenancy")]
        public Tenancy Tenancy { get; set; }
    }

    public partial class ProductCode
    {
        [JsonProperty("ProductCodeId")]
        public string ProductCodeId { get; set; }

        [JsonProperty("ProductCodeType")]
        public string ProductCodeType { get; set; }
    }

    public partial class StateClass
    {
        [JsonProperty("Code")]
        public long Code { get; set; }

        [JsonProperty("Name")]
        public Name Name { get; set; }
    }

    public partial class StateReason
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("Key")]
        public Key Key { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public enum Architecture { X8664 };

    public enum DeviceName { DevSda1, DevSdf, DevXvda };

    public enum EbsStatus { Attached };

    public enum CapacityReservationPreference { Open };

    public enum ClientTokenEnum { C2B5B46DCc64Da65Db4644Ecff8367EaSubnet87Eaf0C11, Empty, The2955B46DBde5256092E5886F00869C04Subnet4A61B82F1 };

    public enum Hypervisor { Xen };

    public enum InstanceType { C4Large, M5Large, T2Large, T2Medium };

    public enum StateEnum { Disabled, Enabled };

    public enum Description { AwsK8SI0027E0Ada6580403C, AwsK8SI00A094Db2Ab98Ec03, AwsK8SI0434Da46Ae565C8C8, Empty, PrimaryNetworkInterface };

    public enum GroupId { Sg032E00F714Dcde828, Sg0617F09D6606Cc5Cc, Sg0Bfb19478C573844C, Sg0D031955142Bb517E, Sg0Dd10Ac8C76C8A357, Sg33B51156, Sg39B5115C, Sg3Eb5115B, Sg5Ab5113F, Sg9Dc9Cff8 };

    public enum Tenancy { Default, FtpAccessForFileTransfer, ItxAjfAppEuwe11E9T8Zvdi7Lsz, ItxAjfCloudFlareDmz6Q5S4Krdj1Db, ItxAjfCustomTomcatLiferay, ItxAjfDatabaseSecurityGroupEuwe111S1Xt9X9Tplq9, ItxAjfEkseuwe111Ttjw0Jk8M4Bi, ItxAjfEksrepoigeniusDevelopment20190822135203604800000004, ItxAjfFileShareEuwe114W0Z8Z9Eth1Q, ItxAjfWebEuwe11Xlim1R10Zkgx };

    public enum NetworkInterfaceStatus { InUse };

    public enum SubnetId { Subnet0Dcdf80208F255B8F, Subnet0F3A0Dfecb90A8420, Subnet4A61B82F, Subnet87Eaf0C1 };

    public enum VpcId { Vpc55916C30 };

    public enum AvailabilityZone { EuWest1A, EuWest1B };

    public enum RootDeviceType { Ebs };

    public enum Name { Running, Stopped };

    public enum StateTransitionReason { Empty, UserInitiated20200310103743Gmt };

    public enum Key { Application, AwsAutoscalingGroupName, AwsEc2LaunchtemplateId, AwsEc2LaunchtemplateVersion, Environment, Hostname, KeyName, KubernetesIoClusterItxAjfEksrepoigeniusDevelopment, Name };

    public enum VirtualizationType { Hvm };

    public partial struct ClientTokenUnion
    {
        public ClientTokenEnum? Enum;
        public Guid? Uuid;

        public static implicit operator ClientTokenUnion(ClientTokenEnum Enum) => new ClientTokenUnion { Enum = Enum };
        public static implicit operator ClientTokenUnion(Guid Uuid) => new ClientTokenUnion { Uuid = Uuid };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ArchitectureConverter.Singleton,
                DeviceNameConverter.Singleton,
                EbsStatusConverter.Singleton,
                CapacityReservationPreferenceConverter.Singleton,
                ClientTokenUnionConverter.Singleton,
                ClientTokenEnumConverter.Singleton,
                HypervisorConverter.Singleton,
                InstanceTypeConverter.Singleton,
                StateEnumConverter.Singleton,
                DescriptionConverter.Singleton,
                GroupIdConverter.Singleton,
                TenancyConverter.Singleton,
                NetworkInterfaceStatusConverter.Singleton,
                SubnetIdConverter.Singleton,
                VpcIdConverter.Singleton,
                AvailabilityZoneConverter.Singleton,
                RootDeviceTypeConverter.Singleton,
                NameConverter.Singleton,
                StateTransitionReasonConverter.Singleton,
                KeyConverter.Singleton,
                VirtualizationTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ArchitectureConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Architecture) || t == typeof(Architecture?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "x86_64")
            {
                return Architecture.X8664;
            }
            throw new Exception("Cannot unmarshal type Architecture");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Architecture)untypedValue;
            if (value == Architecture.X8664)
            {
                serializer.Serialize(writer, "x86_64");
                return;
            }
            throw new Exception("Cannot marshal type Architecture");
        }

        public static readonly ArchitectureConverter Singleton = new ArchitectureConverter();
    }

    internal class DeviceNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DeviceName) || t == typeof(DeviceName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "/dev/sda1":
                    return DeviceName.DevSda1;
                case "/dev/sdf":
                    return DeviceName.DevSdf;
                case "/dev/xvda":
                    return DeviceName.DevXvda;
            }
            throw new Exception("Cannot unmarshal type DeviceName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DeviceName)untypedValue;
            switch (value)
            {
                case DeviceName.DevSda1:
                    serializer.Serialize(writer, "/dev/sda1");
                    return;
                case DeviceName.DevSdf:
                    serializer.Serialize(writer, "/dev/sdf");
                    return;
                case DeviceName.DevXvda:
                    serializer.Serialize(writer, "/dev/xvda");
                    return;
            }
            throw new Exception("Cannot marshal type DeviceName");
        }

        public static readonly DeviceNameConverter Singleton = new DeviceNameConverter();
    }

    internal class EbsStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EbsStatus) || t == typeof(EbsStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "attached")
            {
                return EbsStatus.Attached;
            }
            throw new Exception("Cannot unmarshal type EbsStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EbsStatus)untypedValue;
            if (value == EbsStatus.Attached)
            {
                serializer.Serialize(writer, "attached");
                return;
            }
            throw new Exception("Cannot marshal type EbsStatus");
        }

        public static readonly EbsStatusConverter Singleton = new EbsStatusConverter();
    }

    internal class CapacityReservationPreferenceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CapacityReservationPreference) || t == typeof(CapacityReservationPreference?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "open")
            {
                return CapacityReservationPreference.Open;
            }
            throw new Exception("Cannot unmarshal type CapacityReservationPreference");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CapacityReservationPreference)untypedValue;
            if (value == CapacityReservationPreference.Open)
            {
                serializer.Serialize(writer, "open");
                return;
            }
            throw new Exception("Cannot marshal type CapacityReservationPreference");
        }

        public static readonly CapacityReservationPreferenceConverter Singleton = new CapacityReservationPreferenceConverter();
    }

    internal class ClientTokenUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClientTokenUnion) || t == typeof(ClientTokenUnion?);

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
                            return new ClientTokenUnion { Enum = ClientTokenEnum.Empty };
                        case "2955b46d-bde5-2560-92e5-886f00869c04_subnet-4a61b82f_1":
                            return new ClientTokenUnion { Enum = ClientTokenEnum.The2955B46DBde5256092E5886F00869C04Subnet4A61B82F1 };
                        case "c2b5b46d-cc64-da65-db46-44ecff8367ea_subnet-87eaf0c1_1":
                            return new ClientTokenUnion { Enum = ClientTokenEnum.C2B5B46DCc64Da65Db4644Ecff8367EaSubnet87Eaf0C11 };
                    }
                    Guid guid;
                    if (Guid.TryParse(stringValue, out guid))
                    {
                        return new ClientTokenUnion { Uuid = guid };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ClientTokenUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ClientTokenUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ClientTokenEnum.Empty:
                        serializer.Serialize(writer, "");
                        return;
                    case ClientTokenEnum.The2955B46DBde5256092E5886F00869C04Subnet4A61B82F1:
                        serializer.Serialize(writer, "2955b46d-bde5-2560-92e5-886f00869c04_subnet-4a61b82f_1");
                        return;
                    case ClientTokenEnum.C2B5B46DCc64Da65Db4644Ecff8367EaSubnet87Eaf0C11:
                        serializer.Serialize(writer, "c2b5b46d-cc64-da65-db46-44ecff8367ea_subnet-87eaf0c1_1");
                        return;
                }
            }
            if (value.Uuid != null)
            {
                serializer.Serialize(writer, value.Uuid.Value.ToString("D", System.Globalization.CultureInfo.InvariantCulture));
                return;
            }
            throw new Exception("Cannot marshal type ClientTokenUnion");
        }

        public static readonly ClientTokenUnionConverter Singleton = new ClientTokenUnionConverter();
    }

    internal class ClientTokenEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClientTokenEnum) || t == typeof(ClientTokenEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return ClientTokenEnum.Empty;
                case "2955b46d-bde5-2560-92e5-886f00869c04_subnet-4a61b82f_1":
                    return ClientTokenEnum.The2955B46DBde5256092E5886F00869C04Subnet4A61B82F1;
                case "c2b5b46d-cc64-da65-db46-44ecff8367ea_subnet-87eaf0c1_1":
                    return ClientTokenEnum.C2B5B46DCc64Da65Db4644Ecff8367EaSubnet87Eaf0C11;
            }
            throw new Exception("Cannot unmarshal type ClientTokenEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClientTokenEnum)untypedValue;
            switch (value)
            {
                case ClientTokenEnum.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case ClientTokenEnum.The2955B46DBde5256092E5886F00869C04Subnet4A61B82F1:
                    serializer.Serialize(writer, "2955b46d-bde5-2560-92e5-886f00869c04_subnet-4a61b82f_1");
                    return;
                case ClientTokenEnum.C2B5B46DCc64Da65Db4644Ecff8367EaSubnet87Eaf0C11:
                    serializer.Serialize(writer, "c2b5b46d-cc64-da65-db46-44ecff8367ea_subnet-87eaf0c1_1");
                    return;
            }
            throw new Exception("Cannot marshal type ClientTokenEnum");
        }

        public static readonly ClientTokenEnumConverter Singleton = new ClientTokenEnumConverter();
    }

    internal class HypervisorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Hypervisor) || t == typeof(Hypervisor?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "xen")
            {
                return Hypervisor.Xen;
            }
            throw new Exception("Cannot unmarshal type Hypervisor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Hypervisor)untypedValue;
            if (value == Hypervisor.Xen)
            {
                serializer.Serialize(writer, "xen");
                return;
            }
            throw new Exception("Cannot marshal type Hypervisor");
        }

        public static readonly HypervisorConverter Singleton = new HypervisorConverter();
    }

    internal class InstanceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InstanceType) || t == typeof(InstanceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "c4.large":
                    return InstanceType.C4Large;
                case "m5.large":
                    return InstanceType.M5Large;
                case "t2.large":
                    return InstanceType.T2Large;
                case "t2.medium":
                    return InstanceType.T2Medium;
            }
            throw new Exception("Cannot unmarshal type InstanceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (InstanceType)untypedValue;
            switch (value)
            {
                case InstanceType.C4Large:
                    serializer.Serialize(writer, "c4.large");
                    return;
                case InstanceType.M5Large:
                    serializer.Serialize(writer, "m5.large");
                    return;
                case InstanceType.T2Large:
                    serializer.Serialize(writer, "t2.large");
                    return;
                case InstanceType.T2Medium:
                    serializer.Serialize(writer, "t2.medium");
                    return;
            }
            throw new Exception("Cannot marshal type InstanceType");
        }

        public static readonly InstanceTypeConverter Singleton = new InstanceTypeConverter();
    }

    internal class StateEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StateEnum) || t == typeof(StateEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "disabled":
                    return StateEnum.Disabled;
                case "enabled":
                    return StateEnum.Enabled;
            }
            throw new Exception("Cannot unmarshal type StateEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StateEnum)untypedValue;
            switch (value)
            {
                case StateEnum.Disabled:
                    serializer.Serialize(writer, "disabled");
                    return;
                case StateEnum.Enabled:
                    serializer.Serialize(writer, "enabled");
                    return;
            }
            throw new Exception("Cannot marshal type StateEnum");
        }

        public static readonly StateEnumConverter Singleton = new StateEnumConverter();
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Description.Empty;
                case "Primary network interface":
                    return Description.PrimaryNetworkInterface;
                case "aws-K8S-i-0027e0ada6580403c":
                    return Description.AwsK8SI0027E0Ada6580403C;
                case "aws-K8S-i-00a094db2ab98ec03":
                    return Description.AwsK8SI00A094Db2Ab98Ec03;
                case "aws-K8S-i-0434da46ae565c8c8":
                    return Description.AwsK8SI0434Da46Ae565C8C8;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Description.PrimaryNetworkInterface:
                    serializer.Serialize(writer, "Primary network interface");
                    return;
                case Description.AwsK8SI0027E0Ada6580403C:
                    serializer.Serialize(writer, "aws-K8S-i-0027e0ada6580403c");
                    return;
                case Description.AwsK8SI00A094Db2Ab98Ec03:
                    serializer.Serialize(writer, "aws-K8S-i-00a094db2ab98ec03");
                    return;
                case Description.AwsK8SI0434Da46Ae565C8C8:
                    serializer.Serialize(writer, "aws-K8S-i-0434da46ae565c8c8");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class GroupIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GroupId) || t == typeof(GroupId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "sg-032e00f714dcde828":
                    return GroupId.Sg032E00F714Dcde828;
                case "sg-0617f09d6606cc5cc":
                    return GroupId.Sg0617F09D6606Cc5Cc;
                case "sg-0bfb19478c573844c":
                    return GroupId.Sg0Bfb19478C573844C;
                case "sg-0d031955142bb517e":
                    return GroupId.Sg0D031955142Bb517E;
                case "sg-0dd10ac8c76c8a357":
                    return GroupId.Sg0Dd10Ac8C76C8A357;
                case "sg-33b51156":
                    return GroupId.Sg33B51156;
                case "sg-39b5115c":
                    return GroupId.Sg39B5115C;
                case "sg-3eb5115b":
                    return GroupId.Sg3Eb5115B;
                case "sg-5ab5113f":
                    return GroupId.Sg5Ab5113F;
                case "sg-9dc9cff8":
                    return GroupId.Sg9Dc9Cff8;
            }
            throw new Exception("Cannot unmarshal type GroupId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GroupId)untypedValue;
            switch (value)
            {
                case GroupId.Sg032E00F714Dcde828:
                    serializer.Serialize(writer, "sg-032e00f714dcde828");
                    return;
                case GroupId.Sg0617F09D6606Cc5Cc:
                    serializer.Serialize(writer, "sg-0617f09d6606cc5cc");
                    return;
                case GroupId.Sg0Bfb19478C573844C:
                    serializer.Serialize(writer, "sg-0bfb19478c573844c");
                    return;
                case GroupId.Sg0D031955142Bb517E:
                    serializer.Serialize(writer, "sg-0d031955142bb517e");
                    return;
                case GroupId.Sg0Dd10Ac8C76C8A357:
                    serializer.Serialize(writer, "sg-0dd10ac8c76c8a357");
                    return;
                case GroupId.Sg33B51156:
                    serializer.Serialize(writer, "sg-33b51156");
                    return;
                case GroupId.Sg39B5115C:
                    serializer.Serialize(writer, "sg-39b5115c");
                    return;
                case GroupId.Sg3Eb5115B:
                    serializer.Serialize(writer, "sg-3eb5115b");
                    return;
                case GroupId.Sg5Ab5113F:
                    serializer.Serialize(writer, "sg-5ab5113f");
                    return;
                case GroupId.Sg9Dc9Cff8:
                    serializer.Serialize(writer, "sg-9dc9cff8");
                    return;
            }
            throw new Exception("Cannot marshal type GroupId");
        }

        public static readonly GroupIdConverter Singleton = new GroupIdConverter();
    }

    internal class TenancyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tenancy) || t == typeof(Tenancy?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FTP access for file transfer":
                    return Tenancy.FtpAccessForFileTransfer;
                case "default":
                    return Tenancy.Default;
                case "itx-ajf-AppEUWE11-E9T8ZVDI7LSZ":
                    return Tenancy.ItxAjfAppEuwe11E9T8Zvdi7Lsz;
                case "itx-ajf-CloudFlareDmz-6Q5S4KRDJ1DB":
                    return Tenancy.ItxAjfCloudFlareDmz6Q5S4Krdj1Db;
                case "itx-ajf-DatabaseSecurityGroupEUWE11-1S1XT9X9TPLQ9":
                    return Tenancy.ItxAjfDatabaseSecurityGroupEuwe111S1Xt9X9Tplq9;
                case "itx-ajf-EKSEUWE11-1TTJW0JK8M4BI":
                    return Tenancy.ItxAjfEkseuwe111Ttjw0Jk8M4Bi;
                case "itx-ajf-FileShareEUWE11-4W0Z8Z9ETH1Q":
                    return Tenancy.ItxAjfFileShareEuwe114W0Z8Z9Eth1Q;
                case "itx-ajf-WebEUWE11-XLIM1R10ZKGX":
                    return Tenancy.ItxAjfWebEuwe11Xlim1R10Zkgx;
                case "itx-ajf-custom-TomcatLiferay":
                    return Tenancy.ItxAjfCustomTomcatLiferay;
                case "itx-ajf-eksrepoigenius-development20190822135203604800000004":
                    return Tenancy.ItxAjfEksrepoigeniusDevelopment20190822135203604800000004;
            }
            throw new Exception("Cannot unmarshal type Tenancy");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tenancy)untypedValue;
            switch (value)
            {
                case Tenancy.FtpAccessForFileTransfer:
                    serializer.Serialize(writer, "FTP access for file transfer");
                    return;
                case Tenancy.Default:
                    serializer.Serialize(writer, "default");
                    return;
                case Tenancy.ItxAjfAppEuwe11E9T8Zvdi7Lsz:
                    serializer.Serialize(writer, "itx-ajf-AppEUWE11-E9T8ZVDI7LSZ");
                    return;
                case Tenancy.ItxAjfCloudFlareDmz6Q5S4Krdj1Db:
                    serializer.Serialize(writer, "itx-ajf-CloudFlareDmz-6Q5S4KRDJ1DB");
                    return;
                case Tenancy.ItxAjfDatabaseSecurityGroupEuwe111S1Xt9X9Tplq9:
                    serializer.Serialize(writer, "itx-ajf-DatabaseSecurityGroupEUWE11-1S1XT9X9TPLQ9");
                    return;
                case Tenancy.ItxAjfEkseuwe111Ttjw0Jk8M4Bi:
                    serializer.Serialize(writer, "itx-ajf-EKSEUWE11-1TTJW0JK8M4BI");
                    return;
                case Tenancy.ItxAjfFileShareEuwe114W0Z8Z9Eth1Q:
                    serializer.Serialize(writer, "itx-ajf-FileShareEUWE11-4W0Z8Z9ETH1Q");
                    return;
                case Tenancy.ItxAjfWebEuwe11Xlim1R10Zkgx:
                    serializer.Serialize(writer, "itx-ajf-WebEUWE11-XLIM1R10ZKGX");
                    return;
                case Tenancy.ItxAjfCustomTomcatLiferay:
                    serializer.Serialize(writer, "itx-ajf-custom-TomcatLiferay");
                    return;
                case Tenancy.ItxAjfEksrepoigeniusDevelopment20190822135203604800000004:
                    serializer.Serialize(writer, "itx-ajf-eksrepoigenius-development20190822135203604800000004");
                    return;
            }
            throw new Exception("Cannot marshal type Tenancy");
        }

        public static readonly TenancyConverter Singleton = new TenancyConverter();
    }

    internal class NetworkInterfaceStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NetworkInterfaceStatus) || t == typeof(NetworkInterfaceStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "in-use")
            {
                return NetworkInterfaceStatus.InUse;
            }
            throw new Exception("Cannot unmarshal type NetworkInterfaceStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NetworkInterfaceStatus)untypedValue;
            if (value == NetworkInterfaceStatus.InUse)
            {
                serializer.Serialize(writer, "in-use");
                return;
            }
            throw new Exception("Cannot marshal type NetworkInterfaceStatus");
        }

        public static readonly NetworkInterfaceStatusConverter Singleton = new NetworkInterfaceStatusConverter();
    }

    internal class SubnetIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SubnetId) || t == typeof(SubnetId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "subnet-0dcdf80208f255b8f":
                    return SubnetId.Subnet0Dcdf80208F255B8F;
                case "subnet-0f3a0dfecb90a8420":
                    return SubnetId.Subnet0F3A0Dfecb90A8420;
                case "subnet-4a61b82f":
                    return SubnetId.Subnet4A61B82F;
                case "subnet-87eaf0c1":
                    return SubnetId.Subnet87Eaf0C1;
            }
            throw new Exception("Cannot unmarshal type SubnetId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SubnetId)untypedValue;
            switch (value)
            {
                case SubnetId.Subnet0Dcdf80208F255B8F:
                    serializer.Serialize(writer, "subnet-0dcdf80208f255b8f");
                    return;
                case SubnetId.Subnet0F3A0Dfecb90A8420:
                    serializer.Serialize(writer, "subnet-0f3a0dfecb90a8420");
                    return;
                case SubnetId.Subnet4A61B82F:
                    serializer.Serialize(writer, "subnet-4a61b82f");
                    return;
                case SubnetId.Subnet87Eaf0C1:
                    serializer.Serialize(writer, "subnet-87eaf0c1");
                    return;
            }
            throw new Exception("Cannot marshal type SubnetId");
        }

        public static readonly SubnetIdConverter Singleton = new SubnetIdConverter();
    }

    internal class VpcIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VpcId) || t == typeof(VpcId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "vpc-55916c30")
            {
                return VpcId.Vpc55916C30;
            }
            throw new Exception("Cannot unmarshal type VpcId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VpcId)untypedValue;
            if (value == VpcId.Vpc55916C30)
            {
                serializer.Serialize(writer, "vpc-55916c30");
                return;
            }
            throw new Exception("Cannot marshal type VpcId");
        }

        public static readonly VpcIdConverter Singleton = new VpcIdConverter();
    }

    internal class AvailabilityZoneConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AvailabilityZone) || t == typeof(AvailabilityZone?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "eu-west-1a":
                    return AvailabilityZone.EuWest1A;
                case "eu-west-1b":
                    return AvailabilityZone.EuWest1B;
            }
            throw new Exception("Cannot unmarshal type AvailabilityZone");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AvailabilityZone)untypedValue;
            switch (value)
            {
                case AvailabilityZone.EuWest1A:
                    serializer.Serialize(writer, "eu-west-1a");
                    return;
                case AvailabilityZone.EuWest1B:
                    serializer.Serialize(writer, "eu-west-1b");
                    return;
            }
            throw new Exception("Cannot marshal type AvailabilityZone");
        }

        public static readonly AvailabilityZoneConverter Singleton = new AvailabilityZoneConverter();
    }

    internal class RootDeviceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RootDeviceType) || t == typeof(RootDeviceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ebs")
            {
                return RootDeviceType.Ebs;
            }
            throw new Exception("Cannot unmarshal type RootDeviceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RootDeviceType)untypedValue;
            if (value == RootDeviceType.Ebs)
            {
                serializer.Serialize(writer, "ebs");
                return;
            }
            throw new Exception("Cannot marshal type RootDeviceType");
        }

        public static readonly RootDeviceTypeConverter Singleton = new RootDeviceTypeConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "running":
                    return Name.Running;
                case "stopped":
                    return Name.Stopped;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Running:
                    serializer.Serialize(writer, "running");
                    return;
                case Name.Stopped:
                    serializer.Serialize(writer, "stopped");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class StateTransitionReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StateTransitionReason) || t == typeof(StateTransitionReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return StateTransitionReason.Empty;
                case "User initiated (2020-03-10 10:37:43 GMT)":
                    return StateTransitionReason.UserInitiated20200310103743Gmt;
            }
            throw new Exception("Cannot unmarshal type StateTransitionReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StateTransitionReason)untypedValue;
            switch (value)
            {
                case StateTransitionReason.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case StateTransitionReason.UserInitiated20200310103743Gmt:
                    serializer.Serialize(writer, "User initiated (2020-03-10 10:37:43 GMT)");
                    return;
            }
            throw new Exception("Cannot marshal type StateTransitionReason");
        }

        public static readonly StateTransitionReasonConverter Singleton = new StateTransitionReasonConverter();
    }

    internal class KeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Application":
                    return Key.Application;
                case "Environment":
                    return Key.Environment;
                case "Hostname":
                    return Key.Hostname;
                case "Name":
                    return Key.KeyName;
                case "Name ":
                    return Key.Name;
                case "aws:autoscaling:groupName":
                    return Key.AwsAutoscalingGroupName;
                case "aws:ec2launchtemplate:id":
                    return Key.AwsEc2LaunchtemplateId;
                case "aws:ec2launchtemplate:version":
                    return Key.AwsEc2LaunchtemplateVersion;
                case "kubernetes.io/cluster/itx-ajf-eksrepoigenius-development":
                    return Key.KubernetesIoClusterItxAjfEksrepoigeniusDevelopment;
            }
            throw new Exception("Cannot unmarshal type Key");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Key)untypedValue;
            switch (value)
            {
                case Key.Application:
                    serializer.Serialize(writer, "Application");
                    return;
                case Key.Environment:
                    serializer.Serialize(writer, "Environment");
                    return;
                case Key.Hostname:
                    serializer.Serialize(writer, "Hostname");
                    return;
                case Key.KeyName:
                    serializer.Serialize(writer, "Name");
                    return;
                case Key.Name:
                    serializer.Serialize(writer, "Name ");
                    return;
                case Key.AwsAutoscalingGroupName:
                    serializer.Serialize(writer, "aws:autoscaling:groupName");
                    return;
                case Key.AwsEc2LaunchtemplateId:
                    serializer.Serialize(writer, "aws:ec2launchtemplate:id");
                    return;
                case Key.AwsEc2LaunchtemplateVersion:
                    serializer.Serialize(writer, "aws:ec2launchtemplate:version");
                    return;
                case Key.KubernetesIoClusterItxAjfEksrepoigeniusDevelopment:
                    serializer.Serialize(writer, "kubernetes.io/cluster/itx-ajf-eksrepoigenius-development");
                    return;
            }
            throw new Exception("Cannot marshal type Key");
        }

        public static readonly KeyConverter Singleton = new KeyConverter();
    }

    internal class VirtualizationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VirtualizationType) || t == typeof(VirtualizationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "hvm")
            {
                return VirtualizationType.Hvm;
            }
            throw new Exception("Cannot unmarshal type VirtualizationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VirtualizationType)untypedValue;
            if (value == VirtualizationType.Hvm)
            {
                serializer.Serialize(writer, "hvm");
                return;
            }
            throw new Exception("Cannot marshal type VirtualizationType");
        }

        public static readonly VirtualizationTypeConverter Singleton = new VirtualizationTypeConverter();
    }
}
