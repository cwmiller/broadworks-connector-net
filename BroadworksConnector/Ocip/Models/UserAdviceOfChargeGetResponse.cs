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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:304""}]")]
    public class UserAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:304")]
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

        protected BroadWorksConnector.Ocip.Models.AdviceOfChargeType _aocType;

        [XmlElement(ElementName = "aocType", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:304")]
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
