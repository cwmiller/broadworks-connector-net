using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemShInterfaceRefreshTaskGetRequest.  Provides the status of the system refresh task.  If isRunning is false, numberPublicIdentityRefreshStarted and numberPublicIdentities are omitted.  If isRunning is true, numberPublicIdentities indicates the total number of public identities in the system that will be refreshed by the system refresh task; numberPublicIdentityRefreshesStarted indicates the total number of public identities for which a refresh has been started.
    /// <see cref="SystemShInterfaceRefreshTaskGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16672""}]")]
    public class SystemShInterfaceRefreshTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isRunning;

        [XmlElement(ElementName = "isRunning", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16672")]
        public bool IsRunning
        {
            get => _isRunning;
            set
            {
                IsRunningSpecified = true;
                _isRunning = value;
            }
        }

        [XmlIgnore]
        protected bool IsRunningSpecified { get; set; }

        protected int _numberPublicIdentityRefreshesStarted;

        [XmlElement(ElementName = "numberPublicIdentityRefreshesStarted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16672")]
        public int NumberPublicIdentityRefreshesStarted
        {
            get => _numberPublicIdentityRefreshesStarted;
            set
            {
                NumberPublicIdentityRefreshesStartedSpecified = true;
                _numberPublicIdentityRefreshesStarted = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPublicIdentityRefreshesStartedSpecified { get; set; }

        protected int _numberPublicIdentities;

        [XmlElement(ElementName = "numberPublicIdentities", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16672")]
        public int NumberPublicIdentities
        {
            get => _numberPublicIdentities;
            set
            {
                NumberPublicIdentitiesSpecified = true;
                _numberPublicIdentities = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPublicIdentitiesSpecified { get; set; }

    }
}
