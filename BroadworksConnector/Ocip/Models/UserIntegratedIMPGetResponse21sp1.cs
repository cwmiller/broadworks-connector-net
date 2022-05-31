using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserIntegratedIMPGetRequest21sp1.
    /// The response contains the Integrated IMP specific service attributes for the user.
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// impId
    /// isAlternateImpId
    /// <see cref="UserIntegratedIMPGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:352""}]")]
    public class UserIntegratedIMPGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:352")]
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

        protected string _impId;

        [XmlElement(ElementName = "impId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:352")]
        [MinLength(1)]
        [MaxLength(196)]
        public string ImpId
        {
            get => _impId;
            set
            {
                ImpIdSpecified = true;
                _impId = value;
            }
        }

        [XmlIgnore]
        protected bool ImpIdSpecified { get; set; }

        protected bool _isAlternateImpId;

        [XmlElement(ElementName = "isAlternateImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:352")]
        public bool IsAlternateImpId
        {
            get => _isAlternateImpId;
            set
            {
                IsAlternateImpIdSpecified = true;
                _isAlternateImpId = value;
            }
        }

        [XmlIgnore]
        protected bool IsAlternateImpIdSpecified { get; set; }

    }
}
