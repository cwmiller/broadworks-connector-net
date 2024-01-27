using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkProgressionGetRequest.
    /// <see cref="SystemNetworkProgressionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12833""}]")]
    public class SystemNetworkProgressionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12833")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected int _waitPeriodSeconds;

        [XmlElement(ElementName = "waitPeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12833")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int WaitPeriodSeconds
        {
            get => _waitPeriodSeconds;
            set
            {
                WaitPeriodSecondsSpecified = true;
                _waitPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool WaitPeriodSecondsSpecified { get; set; }

    }
}
