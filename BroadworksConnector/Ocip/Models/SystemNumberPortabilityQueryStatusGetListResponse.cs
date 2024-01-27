using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryStatusGetListRequest.
    /// Contains a table with column headings:
    /// "Status and Treatment File Name".
    /// <see cref="SystemNumberPortabilityQueryStatusGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13423""}]")]
    public class SystemNumberPortabilityQueryStatusGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _statusTable;

        [XmlElement(ElementName = "statusTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13423")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusTable
        {
            get => _statusTable;
            set
            {
                StatusTableSpecified = true;
                _statusTable = value;
            }
        }

        [XmlIgnore]
        protected bool StatusTableSpecified { get; set; }

    }
}
