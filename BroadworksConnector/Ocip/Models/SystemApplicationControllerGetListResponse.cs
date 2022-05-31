using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemApplicationControllerGetListRequest.
    /// Contains a table with column headings: "Name", "Subscriber Id", "Channel Set Id", "Status".
    /// The column values for "Status" can either be "ready" or "notReady".
    /// <see cref="SystemApplicationControllerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2362""}]")]
    public class SystemApplicationControllerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _applicationControllerTable;

        [XmlElement(ElementName = "applicationControllerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2362")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ApplicationControllerTable
        {
            get => _applicationControllerTable;
            set
            {
                ApplicationControllerTableSpecified = true;
                _applicationControllerTable = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationControllerTableSpecified { get; set; }

    }
}
