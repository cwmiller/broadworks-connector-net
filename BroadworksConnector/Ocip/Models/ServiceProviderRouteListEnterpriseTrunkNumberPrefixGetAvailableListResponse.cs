using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest.
    /// Contains a list of available number prefixes not yet assigned to any group.
    /// The column headings are "Number Prefix"","Is Active", “Extension Range Start” and “Extension Range End”.
    /// <see cref="ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:527""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberPrefixTable;

        [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:527")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable
        {
            get => _availableNumberPrefixTable;
            set
            {
                AvailableNumberPrefixTableSpecified = true;
                _availableNumberPrefixTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableNumberPrefixTableSpecified { get; set; }

    }
}
