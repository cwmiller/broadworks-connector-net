using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to
    /// SystemAccountingInhibitedAttributeValuePairCodeGetListRequest. Contains a 2 column
    /// table with column headings "Attribute Value Pair Code" and "Vendor Id".
    /// <see cref="SystemAccountingInhibitedAttributeValuePairCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1557""}]")]
    public class SystemAccountingInhibitedAttributeValuePairCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _inhibitedAttributeValuePairCodeTable;

        [XmlElement(ElementName = "inhibitedAttributeValuePairCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1557")]
        public BroadWorksConnector.Ocip.Models.C.OCITable InhibitedAttributeValuePairCodeTable
        {
            get => _inhibitedAttributeValuePairCodeTable;
            set
            {
                InhibitedAttributeValuePairCodeTableSpecified = true;
                _inhibitedAttributeValuePairCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool InhibitedAttributeValuePairCodeTableSpecified { get; set; }

    }
}
