using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAlternateNumbersGetRequest21.
    /// <see cref="UserAlternateNumbersGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b0d590445194cb49d97af1e45ec12ae:56""}]")]
    public class UserAlternateNumbersGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _distinctiveRing;

        [XmlElement(ElementName = "distinctiveRing", IsNullable = false, Namespace = "")]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public bool DistinctiveRing
        {
            get => _distinctiveRing;
            set
            {
                DistinctiveRingSpecified = true;
                _distinctiveRing = value;
            }
        }

        [XmlIgnore]
        protected bool DistinctiveRingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry01;

        [XmlElement(ElementName = "alternateEntry01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry01
        {
            get => _alternateEntry01;
            set
            {
                AlternateEntry01Specified = true;
                _alternateEntry01 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry01Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry02;

        [XmlElement(ElementName = "alternateEntry02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry02
        {
            get => _alternateEntry02;
            set
            {
                AlternateEntry02Specified = true;
                _alternateEntry02 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry02Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry03;

        [XmlElement(ElementName = "alternateEntry03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry03
        {
            get => _alternateEntry03;
            set
            {
                AlternateEntry03Specified = true;
                _alternateEntry03 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry03Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry04;

        [XmlElement(ElementName = "alternateEntry04", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry04
        {
            get => _alternateEntry04;
            set
            {
                AlternateEntry04Specified = true;
                _alternateEntry04 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry04Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry05;

        [XmlElement(ElementName = "alternateEntry05", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry05
        {
            get => _alternateEntry05;
            set
            {
                AlternateEntry05Specified = true;
                _alternateEntry05 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry05Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry06;

        [XmlElement(ElementName = "alternateEntry06", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry06
        {
            get => _alternateEntry06;
            set
            {
                AlternateEntry06Specified = true;
                _alternateEntry06 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry06Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry07;

        [XmlElement(ElementName = "alternateEntry07", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry07
        {
            get => _alternateEntry07;
            set
            {
                AlternateEntry07Specified = true;
                _alternateEntry07 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry07Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry08;

        [XmlElement(ElementName = "alternateEntry08", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry08
        {
            get => _alternateEntry08;
            set
            {
                AlternateEntry08Specified = true;
                _alternateEntry08 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry08Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry09;

        [XmlElement(ElementName = "alternateEntry09", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry09
        {
            get => _alternateEntry09;
            set
            {
                AlternateEntry09Specified = true;
                _alternateEntry09 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry09Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 _alternateEntry10;

        [XmlElement(ElementName = "alternateEntry10", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b0d590445194cb49d97af1e45ec12ae:56")]
        public BroadWorksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry10
        {
            get => _alternateEntry10;
            set
            {
                AlternateEntry10Specified = true;
                _alternateEntry10 = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateEntry10Specified { get; set; }

    }
}
