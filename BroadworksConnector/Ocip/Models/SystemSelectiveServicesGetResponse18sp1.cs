using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSelectiveServicesGetRequest18sp1.
    /// <see cref="SystemSelectiveServicesGetRequest18sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29640""}]")]
    public class SystemSelectiveServicesGetResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

        [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29640")]
        public BroadWorksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination
        {
            get => _scheduleCombination;
            set
            {
                ScheduleCombinationSpecified = true;
                _scheduleCombination = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleCombinationSpecified { get; set; }

        protected bool _screenPrivateNumber;

        [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29640")]
        public bool ScreenPrivateNumber
        {
            get => _screenPrivateNumber;
            set
            {
                ScreenPrivateNumberSpecified = true;
                _screenPrivateNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenPrivateNumberSpecified { get; set; }

    }
}
