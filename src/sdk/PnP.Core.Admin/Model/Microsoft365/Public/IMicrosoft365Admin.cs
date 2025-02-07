﻿using PnP.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PnP.Core.Admin.Model.Microsoft365
{
    /// <summary>
    /// Microsoft 365 Admin features
    /// </summary>
    public interface IMicrosoft365Admin
    {
        #region Microsoft 365 Group creation support
        /// <summary>
        /// Create a Microsoft 365 Group
        /// </summary>
        /// <param name="graphGroupOptions">Options that define the Microsoft 365 Group to create</param>
        /// <param name="creationOptions">Options that control the group creation process</param>
        /// <returns>PnPContext for the SharePoint site linked the new group</returns>
        Task<PnPContext> CreateGroupAsync(GraphGroupOptions graphGroupOptions, CreationOptions creationOptions = null);

        /// <summary>
        /// Create a Microsoft 365 Group
        /// </summary>
        /// <param name="graphGroupOptions">Options that define the Microsoft 365 Group to create</param>
        /// <param name="creationOptions">Options that control the group creation process</param>
        /// <returns>PnPContext for the SharePoint site linked the new group</returns>
        PnPContext CreateGroup(GraphGroupOptions graphGroupOptions, CreationOptions creationOptions = null);

        /// <summary>
        /// Check if a Microsoft 365 group exists
        /// </summary>
        /// <param name="mailNickName">Microsoft 365 group alias to check for</param>
        /// <returns>True if the group exists, false otherwise</returns>
        Task<bool> GroupExistsAsync(string mailNickName);

        /// <summary>
        /// Check if a Microsoft 365 group exists
        /// </summary>
        /// <param name="mailNickName">Microsoft 365 group alias to check for</param>
        /// <returns>True if the group exists, false otherwise</returns>
        bool GroupExists(string mailNickName);
        #endregion

        #region Multi-geo support
        /// <summary>
        /// Checks if this tenant is a multi-geo tenant
        /// </summary>
        /// <returns>True if multi-geo, false otherwise</returns>
        Task<bool> IsMultiGeoTenantAsync();

        /// <summary>
        /// Checks if this tenant is a multi-geo tenant
        /// </summary>
        /// <returns>True if multi-geo, false otherwise</returns>
        bool IsMultiGeoTenant();

        /// <summary>
        /// Returns a list of multi-geo locations for this tenant
        /// </summary>
        /// <returns>List of multi-geo locations if multi-geo, null otherwise</returns>
        Task<List<IGeoLocationInformation>> GetMultiGeoLocationsAsync();

        /// <summary>
        /// Returns a list of multi-geo locations for this tenant
        /// </summary>
        /// <returns>List of multi-geo locations if multi-geo, null otherwise</returns>
        List<IGeoLocationInformation> GetMultiGeoLocations();
        #endregion

        #region Access token analysis
        /// <summary>
        /// Checks if the current access token holds the requested role
        /// </summary>
        /// <param name="role">Role to check for</param>
        /// <returns>True if the token has the role, false otherwise</returns>
        Task<bool> AccessTokenHasRoleAsync(string role);

        /// <summary>
        /// Checks if the current access token holds the requested role
        /// </summary>
        /// <param name="role">Role to check for</param>
        /// <returns>True if the token has the role, false otherwise</returns>
        bool AccessTokenHasRole(string role);

        /// <summary>
        /// Checks if the provided access token holds the requested role
        /// </summary>
        /// <param name="accessToken">Accesstoken to inspect</param>
        /// <param name="role">Role to check for</param>
        /// <returns>True if the token has the role, false otherwise</returns>
        bool AccessTokenHasRole(string accessToken, string role);

        /// <summary>
        /// Checks if the current access token holds the requested scope
        /// </summary>
        /// <param name="scope">Scopee to check for</param>
        /// <returns>True if the token has the scope, false otherwise</returns>
        Task<bool> AccessTokenHasScopeAsync(string scope);

        /// <summary>
        /// Checks if the current access token holds the requested scope
        /// </summary>
        /// <param name="scope">Scope to check for</param>
        /// <returns>True if the token has the scope, false otherwise</returns>
        bool AccessTokenHasScope(string scope);

        /// <summary>
        /// Checks if the provided access token holds the requested scope
        /// </summary>
        /// <param name="accessToken">Accesstoken to inspect</param>
        /// <param name="scope">Scope to check for</param>
        /// <returns>True if the token has the scope, false otherwise</returns>
        bool AccessTokenHasScope(string accessToken, string scope);

        /// <summary>
        /// Checks if the current access token uses application permissions
        /// </summary>
        /// <returns>True if using application permissions, false otherwise</returns>
        Task<bool> AccessTokenUsesApplicationPermissionsAsync();

        /// <summary>
        /// Checks if the current access token uses application permissions
        /// </summary>
        /// <returns>True if using application permissions, false otherwise</returns>
        bool AccessTokenUsesApplicationPermissions();

        /// <summary>
        /// Checks if the provided access token uses application permissions
        /// </summary>
        /// <param name="accessToken">Accesstoken to inspect</param>
        /// <returns>True if using application permissions, false otherwise</returns>
        bool AccessTokenUsesApplicationPermissions(string accessToken);
        #endregion

        #region Sensitivity labels
        /// <summary>
        /// Get the available sensitivity labels for the calling user or application
        /// </summary>
        /// <returns>List of sensitivity labels</returns>
        Task<List<ISensitivityLabel>> GetSensitivityLabelsAsync();

        /// <summary>
        /// Get the available sensitivity labels for the calling user or application
        /// </summary>
        /// <returns>List of sensitivity labels</returns>
        List<ISensitivityLabel> GetSensitivityLabels();
        #endregion
    }
}
