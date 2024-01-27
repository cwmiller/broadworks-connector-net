using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCommunicationBarringAlternateCallIndicatorGetListRequest. Contains a table with one row per Communication Barring Alternate Call Indicator.  The table column headings are: "Alternate Call Indicator" and "Network Server Alternate Call Indicator".
    /// <see cref="SystemCommunicationBarringAlternateCallIndicatorGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5662""}]")]
    public class SystemCommunicationBarringAlternateCallIndicatorGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

        [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5662")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable
        {
            get => _alternateCallIndicatorTable;
            set
            {
                AlternateCallIndicatorTableSpecified = true;
                _alternateCallIndicatorTable = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCallIndicatorTableSpecified { get; set; }

    }
}
