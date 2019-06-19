using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserRoutePointCallDispositionCodeGetAvailableListRequest.
    /// This list may include Group/Enterprise level codes in addition to the Route Point level codes,
    /// depending on the call center disposition codes settings.
    /// Only active codes are included in the list.
    /// Contains a table with column headings: "Code", "Description" and "Level".
    /// Level column can be any of the values in the data type CallDispositionCodeLevel.
    /// <see cref="UserRoutePointCallDispositionCodeGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:1281""}]")]
    public class UserRoutePointCallDispositionCodeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dispositionCodesTable;

        [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1281")]
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
        public bool DispositionCodesTableSpecified { get; set; }

    }
}
