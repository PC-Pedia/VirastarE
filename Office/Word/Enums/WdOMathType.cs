﻿using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
    /// <summary>
    /// SupportByVersion Word 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197281.aspx </remarks>
    [SupportByVersion("Word", 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum WdOMathType
    {
        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// </summary>
        /// <remarks>0</remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        wdOMathDisplay = 0,

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        wdOMathInline = 1
    }
}