using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the specified Call Recording platform.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallRecordingModifyPlatformRequest22
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingModifyPlatformRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24752"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24757""}]}]")]
    public class SystemCallRecordingModifyPlatformRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        private int? _port;

        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaStream _mediaStream;

        [XmlElement(ElementName = "mediaStream", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        public BroadWorksConnector.Ocip.Models.MediaStream MediaStream
        {
            get => _mediaStream;
            set
            {
                MediaStreamSpecified = true;
                _mediaStream = value;
            }
        }

        [XmlIgnore]
        protected bool MediaStreamSpecified { get; set; }

        private bool _becomeSystemDefault;

        [XmlElement(ElementName = "becomeSystemDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24757")]
        public bool BecomeSystemDefault
        {
            get => _becomeSystemDefault;
            set
            {
                BecomeSystemDefaultSpecified = true;
                _becomeSystemDefault = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeSystemDefaultSpecified { get; set; }

        private string _becomeResellerDefault;

        [XmlElement(ElementName = "becomeResellerDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24757")]
        [MinLength(1)]
        [MaxLength(30)]
        public string BecomeResellerDefault
        {
            get => _becomeResellerDefault;
            set
            {
                BecomeResellerDefaultSpecified = true;
                _becomeResellerDefault = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeResellerDefaultSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TransportProtocol _transportType;

        [XmlElement(ElementName = "transportType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol TransportType
        {
            get => _transportType;
            set
            {
                TransportTypeSpecified = true;
                _transportType = value;
            }
        }

        [XmlIgnore]
        protected bool TransportTypeSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion _schemaVersion;

        [XmlElement(ElementName = "schemaVersion", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        public BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion
        {
            get => _schemaVersion;
            set
            {
                SchemaVersionSpecified = true;
                _schemaVersion = value;
            }
        }

        [XmlIgnore]
        protected bool SchemaVersionSpecified { get; set; }

        private bool _supportVideoRecording;

        [XmlElement(ElementName = "supportVideoRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24752")]
        public bool SupportVideoRecording
        {
            get => _supportVideoRecording;
            set
            {
                SupportVideoRecordingSpecified = true;
                _supportVideoRecording = value;
            }
        }

        [XmlIgnore]
        protected bool SupportVideoRecordingSpecified { get; set; }

    }
}
