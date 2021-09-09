const multiwallet = 
{
  web3Modal : {},

  web3provider : {},

  ConnectWallet : async function()
  {
    let Web3Modal = window.Web3Modal.default;
    let WalletConnectProvider = window.WalletConnectProvider.default;
    let Fortmatic = window.Fortmatic;
    let evmChains = window.evmChains;

    const providerOptions = {
      walletconnect: {
        package: WalletConnectProvider,
        options: {
          infuraId: client_config.current.infuraId,
        },
      },
  
      fortmatic: {
        package: Fortmatic,
        options: {
          key: client_config.current.formaticKey,
        },
      },
    };
  
    web3Modal = new Web3Modal({
      cacheProvider: false,
      providerOptions,
      disableInjectedProvider: false,
    });
  
    web3provider = await web3Modal.connect();

    web3provider.on("accountsChanged", (accounts) => {
      unityInstance.SendMessage('Web3EventsListener', 'OnAccountsChanged');
    });
  
    web3provider.on("chainChanged", (chainId) => {
      unityInstance.SendMessage('Web3EventsListener', 'OnChainChanged');
    });
  
    web3provider.on("networkChanged", (networkId) => {
      unityInstance.SendMessage('Web3EventsListener', 'OnNetworkChanged');
    });
  }
}