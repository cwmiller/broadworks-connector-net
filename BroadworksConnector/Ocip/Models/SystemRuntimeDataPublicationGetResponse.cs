using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRuntimeDataPublicationGetRequest.
    /// The response contains the system call admission control parameters information.
    /// The following elements are only used in AS data mode:
    /// enableRuntimeDataSync, value "false" is returned in XS data mode.
    /// runtimeDataSyncIntervalInMilliSeconds value "1000" is returned in XS data mode.
    /// <see cref="SystemRuntimeDataPublicationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15590""}]")]
    public class SystemRuntimeDataPublicationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableRuntimeDataSync;

        [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15590")]
        public bool EnableRuntimeDataSync
        {
            get => _enableRuntimeDataSync;
            set
            {
                EnableRuntimeDataSyncSpecified = true;
                _enableRuntimeDataSync = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRuntimeDataSyncSpecified { get; set; }

        protected int _runtimeDataSyncIntervalInMilliSeconds;

        [XmlElement(ElementName = "runtimeDataSyncIntervalInMilliSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15590")]
        [MinInclusive(500)]
        [MaxInclusive(360000)]
        public int RuntimeDataSyncIntervalInMilliSeconds
        {
            get => _runtimeDataSyncIntervalInMilliSeconds;
            set
            {
                RuntimeDataSyncIntervalInMilliSecondsSpecified = true;
                _runtimeDataSyncIntervalInMilliSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RuntimeDataSyncIntervalInMilliSecondsSpecified { get; set; }

    }
}
