using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system call admission control parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// enableRuntimeDataSync,
    /// runtimeIntervalInMilliSeconds
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15826""}]")]
    public class SystemRuntimeDataPublicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableRuntimeDataSync;

        [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15826")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15826")]
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
