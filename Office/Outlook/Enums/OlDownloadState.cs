﻿using NetOffice.Attributes;
namespace NetOffice.OutlookApi.Enums
{
    /// <summary>
    /// SupportByVersion Outlook 10, 11, 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff870187.aspx </remarks>
    [SupportByVersion("Outlook", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum OlDownloadState
    {
        /// <summary>
        /// SupportByVersion Outlook 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>0</remarks>
        [SupportByVersion("Outlook", 10, 11, 12, 14, 15, 16)]
        olHeaderOnly = 0,

        /// <summary>
        /// SupportByVersion Outlook 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Outlook", 10, 11, 12, 14, 15, 16)]
        olFullItem = 1
    }
}