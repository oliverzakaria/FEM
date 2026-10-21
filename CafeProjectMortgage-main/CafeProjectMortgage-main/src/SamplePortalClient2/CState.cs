// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CState
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CState
  {
    private Color mpBackColor;
    private Color mpForeColor;
    private string msDescription;
    private AgentStateId meId;
    protected CApp mpApp;
    private LogFile logFile = new LogFile();

    public virtual bool EnableHangup => false;

    public virtual bool EnableHold => false;

    public virtual bool Enable3Way => false;

    public virtual bool EnableRecord => false;

    public virtual bool EnableNextCall => false;

    public virtual bool EnableLogout => true;

    public virtual bool EnablePlay => false;

    public virtual bool EnableDial => false;

    public virtual bool EnableAvailable => false;

    public virtual bool EnableUnavailable => false;

    public virtual bool EnableConference => false;

    public virtual bool EnableConsult => false;

    public virtual bool EnableTransfer => false;

    public Color BackColor => this.mpBackColor;

    public Color ForeColor => this.mpForeColor;

    public string Description => this.msDescription;

    public AgentStateId Id => this.meId;

    internal CState(
      AgentStateId eId,
      string sDescription,
      Color pBackColor,
      Color pForeColor,
      CApp pApp)
    {
      this.meId = eId;
      this.msDescription = sDescription;
      this.mpBackColor = pBackColor;
      this.mpForeColor = pForeColor;
      this.mpApp = pApp;
    }

    internal virtual void Enter(CAgentEvent pEvent) => this.logFile.LogMessageToFile(" |INFO| CEventManager.CState.Enter() -  Description< " + this.msDescription + ">, ID <" + this.meId.ToString() + "> Type<" + this.GetType().ToString() + " >");

    internal virtual void Exit() => this.logFile.LogMessageToFile(" |INFO| CEventManager.CState.Exit() -  Description< " + this.msDescription + ">, ID <" + this.meId.ToString() + "> Type<" + this.GetType().ToString() + " >");
  }
}
