const client_api = 
{
  ConnectWallet : function()
  {
    multiwallet.ConnectWallet();
  },

  GetWalletAddress : function() 
  {
    var address = web3.currentProvider.selectedAddress;
    if (!address)
      return '';
    
    return utils.StringToBuffer(address);
  }
};


mergeInto(LibraryManager.library, client_api);