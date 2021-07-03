using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all matching system-level domains and all matching reseller level domains.
    /// If excludeReseller is specified, returns all matching system-level domain names only.
    /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
    /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// 
    /// The response is either SystemDomainGetListResponse22 or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// includeReseller
    /// resellerId
    /// 
    /// Replaced by SystemDomainGetListRequest22V2 in AS data mode.
    /// <see cref="SystemDomainGetListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDomainGetListRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26408""}]")]
    public class SystemDomainGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26408")]
        public bool ExcludeReseller
        {
            get => _excludeReseller;
            set
            {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeResellerSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26408")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

    }
}
