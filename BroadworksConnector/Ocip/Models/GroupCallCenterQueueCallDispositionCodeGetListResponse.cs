using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterQueueCallDispositionCodeGetListRequest.
    /// Contains a table with column headings: "Is Active", "Code", "Description" and "Level".
    /// Level column can be any of the values in the data type CallDispositionCodeLevel.
    /// <see cref="GroupCallCenterQueueCallDispositionCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5537""}]")]
    public class GroupCallCenterQueueCallDispositionCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dispositionCodesTable;

        [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5537")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DispositionCodesTable
        {
            get => _dispositionCodesTable;
            set
            {
                DispositionCodesTableSpecified = true;
                _dispositionCodesTable = value;
            }
        }

        [XmlIgnore]
        protected bool DispositionCodesTableSpecified { get; set; }

    }
}
