using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallRecordingGetRequest.
    /// The response contains the enterprise's Call Recording attributes.
    /// <see cref="EnterpriseCallRecordingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:70""}]")]
    public class EnterpriseCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useCloudPBX;

        [XmlElement(ElementName = "useCloudPBX", IsNullable = false, Namespace = "")]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:70")]
        public bool UseCloudPBX
        {
            get => _useCloudPBX;
            set
            {
                UseCloudPBXSpecified = true;
                _useCloudPBX = value;
            }
        }

        [XmlIgnore]
        protected bool UseCloudPBXSpecified { get; set; }

        protected bool _useEnterpriseSetting;

        [XmlElement(ElementName = "useEnterpriseSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:70")]
        public bool UseEnterpriseSetting
        {
            get => _useEnterpriseSetting;
            set
            {
                UseEnterpriseSettingSpecified = true;
                _useEnterpriseSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseEnterpriseSettingSpecified { get; set; }

        protected string _fQDN;

        [XmlElement(ElementName = "FQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:70")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FQDN
        {
            get => _fQDN;
            set
            {
                FQDNSpecified = true;
                _fQDN = value;
            }
        }

        [XmlIgnore]
        protected bool FQDNSpecified { get; set; }

    }
}
