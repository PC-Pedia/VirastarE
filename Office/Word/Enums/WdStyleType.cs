﻿using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
    /// <summary>
    /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196870.aspx </remarks>
    [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum WdStyleType
    {
        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdStyleTypeParagraph = 1,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdStyleTypeCharacter = 2,

        /// <summary>
        /// SupportByVersion Word 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>3</remarks>
        [SupportByVersion("Word", 10, 11, 12, 14, 15, 16)]
        wdStyleTypeTable = 3,

        /// <summary>
        /// SupportByVersion Word 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>4</remarks>
        [SupportByVersion("Word", 10, 11, 12, 14, 15, 16)]
        wdStyleTypeList = 4,

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// </summary>
        /// <remarks>5</remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        wdStyleTypeParagraphOnly = 5,

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// </summary>
        /// <remarks>6</remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        wdStyleTypeLinked = 6
    }
}