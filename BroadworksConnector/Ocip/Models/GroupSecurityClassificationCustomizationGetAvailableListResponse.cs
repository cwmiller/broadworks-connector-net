using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupClassificationCustomizationGetAvailableListRequest.
    /// Returns the available group security classifications.
    /// Contains a table with column headings:
    /// "SystemSecurityClassification", "CustomizedSecurityClassification"
    /// <see cref="GroupClassificationCustomizationGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6689""}]")]
    public class GroupSecurityClassificationCustomizationGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationNameTable;

        [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6689")]
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
        public bool SecurityClassificationNameTableSpecified { get; set; }

    }
}
