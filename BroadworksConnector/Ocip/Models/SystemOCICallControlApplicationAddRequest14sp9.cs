using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an application to the OCI call control application list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemOCICallControlApplicationAddRequest17
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemOCICallControlApplicationAddRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28572""}]")]
    public class SystemOCICallControlApplicationAddRequest14sp9 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28572")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationIdSpecified { get; set; }

        protected bool _enableSystemWide;

        [XmlElement(ElementName = "enableSystemWide", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28572")]
        public bool EnableSystemWide
        {
            get => _enableSystemWide;
            set
            {
                EnableSystemWideSpecified = true;
                _enableSystemWide = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSystemWideSpecified { get; set; }

        protected int _notificationTimeoutSeconds;

        [XmlElement(ElementName = "notificationTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28572")]
        [MinInclusive(2)]
        [MaxInclusive(30)]
        public int NotificationTimeoutSeconds
        {
            get => _notificationTimeoutSeconds;
            set
            {
                NotificationTimeoutSecondsSpecified = true;
                _notificationTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool NotificationTimeoutSecondsSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:28572")]
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

    }
}
