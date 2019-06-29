using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAdviceOfChargeGetRequest.
    /// <see cref="UserAdviceOfChargeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:302""}]")]
    public class UserAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:302")]
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

        private BroadWorksConnector.Ocip.Models.AdviceOfChargeType _aocType;

        [XmlElement(ElementName = "aocType", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:302")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeType AocType
        {
            get => _aocType;
            set
            {
                AocTypeSpecified = true;
                _aocType = value;
            }
        }

        [XmlIgnore]
        protected bool AocTypeSpecified { get; set; }

    }
}
