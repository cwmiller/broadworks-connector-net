using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemServiceCodeGetListRequest.
    /// Contains a table of defined service codes
    /// The column headings are: "Service Code", and "Description".
    /// <see cref="SystemServiceCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16342""}]")]
    public class SystemServiceCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceCodeTable;

        [XmlElement(ElementName = "serviceCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16342")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceCodeTable
        {
            get => _serviceCodeTable;
            set
            {
                ServiceCodeTableSpecified = true;
                _serviceCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceCodeTableSpecified { get; set; }

    }
}
