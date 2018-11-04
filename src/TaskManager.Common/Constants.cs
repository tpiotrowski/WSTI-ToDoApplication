﻿namespace TaskManager.Common
{
    public static class Constants
    {
        public static class MediaTypeNames
        {
            public static string ApplicationXml = "application/xml";
            public static string TextXml = "text/xml";
            public static string ApplicationJson = "application/json";
            public static string TextJson = "text/json";
        }

        public static class Paging
        {
            public const int MinPageSize = 1;
            public const int MinPageNumber = 1;
            public const int DefaultPageNumber = 1;
        }

        public static class CommonParameterNames
        {
            public const string PageNumber = "pageNumber";
            public const string PageSize = "pageSize";
        }

        public static class CommonLinkRelValues
        {
            public const string Self = "self";
            public const string All = "all";
            public const string CurrentPage = "currentPage";
            public const string PreviousPage = "previousPage";
            public const string NextPage = "nextPage";
        }

        public static class CommonRoutingDefinitions
        {
            public const string ApiSegmentName = "api";
            public const string ApiVersionSegmentName = "apiVersion";
            public const string CurrentApiVersion = "v1";
        }

        public static class SchemeTypes
        {
            public const string Basic = "basic";
        }

        public static class RoleNames
        {
            public const string Admin = "Admin";
            public const string SuperUser = "SuperUser";
            public const string User = "User";
        }

        public const string DefaultLegacyNamespace = "http://tempuri.org/";
    }
}
