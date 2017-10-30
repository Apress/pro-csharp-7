<%@ Application Language="C#" %>
<%@ Import Namespace="AutoLotDAL.Repos" %>

<script runat="server">
    
    // Define a static level Cache member variable. 
    static Cache _theCache;
    
    void Application_Start(Object sender, EventArgs e) {
        // First assign the static '_theCache' variable.
        _theCache = Context.Cache;
 
        // When the application starts up,
        // read the current records in the
        // Inventory table of the Cars DB.
        var theCars = new InventoryRepo().GetAll();
        // Now store list in the cache.
        _theCache.Insert("CarList",
             theCars, null,
             DateTime.Now.AddSeconds(15),
             Cache.NoSlidingExpiration,
             CacheItemPriority.Default,
             UpdateCarInventory);
    }

    // The target for the CacheItemRemovedCallback delegate.
    static void UpdateCarInventory(string key, object item,
         CacheItemRemovedReason reason)
    {
        // Get the list
        var theCars = new InventoryRepo().GetAll();
        // Now store in the cache.
        _theCache.Insert("CarList",
             theCars, null,
             DateTime.Now.AddSeconds(15),
             Cache.NoSlidingExpiration,
             CacheItemPriority.Default,
             UpdateCarInventory);
    }

    void Application_End(Object sender, EventArgs e) {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(Object sender, EventArgs e) { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(Object sender, EventArgs e) {
        // Code that runs when a new session is started

    }

    void Session_End(Object sender, EventArgs e) {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
