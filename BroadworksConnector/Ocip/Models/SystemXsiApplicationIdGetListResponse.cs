using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemXsiApplicationIdGetListRequest
    /// Contains a table with column headings: "Xsi Application Id", "Description".
    /// <see cref="SystemXsiApplicationIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19676""}]")]
    public class SystemXsiApplicationIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _xsiApplicationIdTable;

        [XmlElement(ElementName = "xsiApplicationIdTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19676")]
        public BroadWorksConnector.Ocip.Models.C.OCITable XsiApplicationIdTable
        {
            get => _xsiApplicationIdTable;
            set
            {
                XsiApplicationIdTableSpecified = true;
                _xsiApplicationIdTable = value;
            }
        }

        [XmlIgnore]
        protected bool XsiApplicationIdTableSpecified { get; set; }

    }
}
