// -----------------------------------------------------------------------
//  <copyright file="LeaderboardColumn.cs" company="Microsoft">
//      Copyright (c) Microsoft. All rights reserved.
//      Licensed under the MIT license. See LICENSE file in the project root for full license information.
//  </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Xbox.Services.Leaderboard
{
    using global::System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public enum SortOrder
    {
        Ascending,
        Descending,
    }

    public class LeaderboardQuery
    {

        public bool SkipResultToMe
        {
            get;
            set;
        }

        public uint SkipResultsToRank
        {
            get;
            set;
        }

        public uint MaxItems
        {
            get;
            set;
        }
        public SortOrder Order
        {
            get;
            set;
        }

    }
}