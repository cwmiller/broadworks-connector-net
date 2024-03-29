using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseSecurityClassificationCustomizationGetAvailableListRequest.
    /// Returns the available group security classifications.
    /// Contains a table with column headings:
    /// "SystemSecurityClassification", "CustomizedSecurityClassification"
    /// <see cref="EnterpriseSecurityClassificationCustomizationGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:522""}]")]
    public class EnterpriseSecurityClassificationCustomizationGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationNameTable;

        [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:522")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SecurityClassificationNameTable
        {
            get => _securityClassificationNameTable;
            set
            {
                SecurityClassificationNameTableSpecified = true;
                _securityClassificationNameTable = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationNameTableSpecified { get; set; }

    }
}
