using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemXsiPolicyProfileGetListRequest
    /// Contains a table with column headings: "Name", "Level", "Description", "Default".
    /// <see cref="SystemXsiPolicyProfileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19843""}]")]
    public class SystemXsiPolicyProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _xsiPolicyProfileTable;

        [XmlElement(ElementName = "xsiPolicyProfileTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19843")]
        public BroadWorksConnector.Ocip.Models.C.OCITable XsiPolicyProfileTable
        {
            get => _xsiPolicyProfileTable;
            set
            {
                XsiPolicyProfileTableSpecified = true;
                _xsiPolicyProfileTable = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileTableSpecified { get; set; }

    }
}
