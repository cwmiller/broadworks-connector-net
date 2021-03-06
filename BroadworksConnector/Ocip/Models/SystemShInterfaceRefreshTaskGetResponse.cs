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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16452""}]")]
    public class SystemShInterfaceRefreshTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isRunning;

        [XmlElement(ElementName = "isRunning", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16452")]
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

        private int _numberPublicIdentityRefreshesStarted;

        [XmlElement(ElementName = "numberPublicIdentityRefreshesStarted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16452")]
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

        private int _numberPublicIdentities;

        [XmlElement(ElementName = "numberPublicIdentities", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16452")]
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
