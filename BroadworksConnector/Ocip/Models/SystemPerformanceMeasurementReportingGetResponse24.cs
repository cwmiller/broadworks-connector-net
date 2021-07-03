using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPerformanceMeasurementReportingGetRequest24.
    /// <see cref="SystemPerformanceMeasurementReportingGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14374""}]")]
    public class SystemPerformanceMeasurementReportingGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private int _reportingInterval;

        [XmlElement(ElementName = "reportingInterval", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        [MinInclusive(5)]
        [MaxInclusive(45000)]
        public int ReportingInterval
        {
            get => _reportingInterval;
            set
            {
                ReportingIntervalSpecified = true;
                _reportingInterval = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingIntervalSpecified { get; set; }

        private bool _resetMeasurementsAfterEachReport;

        [XmlElement(ElementName = "resetMeasurementsAfterEachReport", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool ResetMeasurementsAfterEachReport
        {
            get => _resetMeasurementsAfterEachReport;
            set
            {
                ResetMeasurementsAfterEachReportSpecified = true;
                _resetMeasurementsAfterEachReport = value;
            }
        }

        [XmlIgnore]
        protected bool ResetMeasurementsAfterEachReportSpecified { get; set; }

        private bool _reportEnterprise;

        [XmlElement(ElementName = "reportEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool ReportEnterprise
        {
            get => _reportEnterprise;
            set
            {
                ReportEnterpriseSpecified = true;
                _reportEnterprise = value;
            }
        }

        [XmlIgnore]
        protected bool ReportEnterpriseSpecified { get; set; }

        private bool _reportServiceProvider;

        [XmlElement(ElementName = "reportServiceProvider", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool ReportServiceProvider
        {
            get => _reportServiceProvider;
            set
            {
                ReportServiceProviderSpecified = true;
                _reportServiceProvider = value;
            }
        }

        [XmlIgnore]
        protected bool ReportServiceProviderSpecified { get; set; }

        private bool _reportDevice;

        [XmlElement(ElementName = "reportDevice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool ReportDevice
        {
            get => _reportDevice;
            set
            {
                ReportDeviceSpecified = true;
                _reportDevice = value;
            }
        }

        [XmlIgnore]
        protected bool ReportDeviceSpecified { get; set; }

        private bool _reportTable;

        [XmlElement(ElementName = "reportTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public bool ReportTable
        {
            get => _reportTable;
            set
            {
                ReportTableSpecified = true;
                _reportTable = value;
            }
        }

        [XmlIgnore]
        protected bool ReportTableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.PerformanceMeasurementReportingEncoding _reportEncoding;

        [XmlElement(ElementName = "reportEncoding", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14374")]
        public BroadWorksConnector.Ocip.Models.PerformanceMeasurementReportingEncoding ReportEncoding
        {
            get => _reportEncoding;
            set
            {
                ReportEncodingSpecified = true;
                _reportEncoding = value;
            }
        }

        [XmlIgnore]
        protected bool ReportEncodingSpecified { get; set; }

    }
}
