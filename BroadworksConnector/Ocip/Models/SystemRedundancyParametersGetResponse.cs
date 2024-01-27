using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemRedundancyParametersGetResponse16sp2
    /// 
    /// Response to SystemRedundancyParametersGetRequest.
    /// Contains a list of system Redundancy parameters.
    /// <see cref="SystemRedundancyParametersGetResponse16sp2"/>
    /// <see cref="SystemRedundancyParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29550""}]")]
    public class SystemRedundancyParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _rollBackTimerMinutes;

        [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29550")]
        [MinInclusive(0)]
        [MaxInclusive(3600)]
        public int RollBackTimerMinutes
        {
            get => _rollBackTimerMinutes;
            set
            {
                RollBackTimerMinutesSpecified = true;
                _rollBackTimerMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool RollBackTimerMinutesSpecified { get; set; }

    }
}
