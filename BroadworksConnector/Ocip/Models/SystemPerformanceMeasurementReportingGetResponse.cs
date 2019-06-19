using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPerformanceMeasurementReportingGetRequest.
    /// 
    /// Replaced by: SystemPerformanceMeasurementReportingGetResponse22
    /// <see cref="SystemPerformanceMeasurementReportingGetRequest"/>
    /// <see cref="SystemPerformanceMeasurementReportingGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38889""}]")]
    public class SystemPerformanceMeasurementReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool IsActiveSpecified { get; set; }

        private int _reportingInterval;

        [XmlElement(ElementName = "reportingInterval", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool ReportingIntervalSpecified { get; set; }

        private bool _resetMeasurementsAfterEachReport;

        [XmlElement(ElementName = "resetMeasurementsAfterEachReport", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool ResetMeasurementsAfterEachReportSpecified { get; set; }

        private bool _reportEnterprise;

        [XmlElement(ElementName = "reportEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool ReportEnterpriseSpecified { get; set; }

        private bool _reportServiceProvider;

        [XmlElement(ElementName = "reportServiceProvider", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool ReportServiceProviderSpecified { get; set; }

        private bool _reportDevice;

        [XmlElement(ElementName = "reportDevice", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38889")]
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
        public bool ReportDeviceSpecified { get; set; }

    }
}
