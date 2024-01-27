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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2041""}]")]
    public class SystemAccountingInhibitedAttributeValuePairCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _inhibitedAttributeValuePairCodeTable;

        [XmlElement(ElementName = "inhibitedAttributeValuePairCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2041")]
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
        protected bool InhibitedAttributeValuePairCodeTableSpecified { get; set; }

    }
}
