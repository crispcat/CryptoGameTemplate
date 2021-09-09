namespace EthereumClient
{
  #if UNITY_EDITOR

  using UnityEngine;
  
  /// <summary>
  /// Mock for unity editor api calls
  /// </summary>
  public class UnityEditorEthereumProvider : IEthereumProvider
  {
    public void ConnectWallet()
    {
      Debug.Log("UnityEditorEthereumProvider: Mock wallet connected");
    }

    public string GetWalletAddress()
    {
      return "0x0000000000000000000000000000000000000000";
    }
  }
  
  #endif
}