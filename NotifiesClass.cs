using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpMeNow
{
    public enum eNotifyType { MessageOnError, ErrorWithoutMessage };
    public enum eLevel { debug = 0, info = 1, warning = 2, error = 3, fatal = 4 };

    public enum eInfoLevel { most = 0, more = 1, normal = 2, few = 3, less = 4, lesser = 5 };

    public class InfoCode
    {
        public string Code;
        public InfoCode(string code)
        {
            Code = code;
        }
    }
    public class NotifyInfoCodes
    {

        public static string DataSaved = "DATA_SAVED";
        public static string NewData = "DATA_NEW";
        public static string EditData = "DATA_EDIT";
        public static string FillData = "FILL_DATA";
        public static string DataFilled = "DATA_FILLED";

        public List<InfoCode> Codes = new List<InfoCode>();

        public void FillDefaultData()
        {
            Codes.Add(new InfoCode(DataSaved));
            Codes.Add(new InfoCode(NewData));
            Codes.Add(new InfoCode(EditData));
            Codes.Add(new InfoCode(FillData));
            Codes.Add(new InfoCode(DataFilled));
        }

        public bool IsCode(string code)
        {
            var ic = Codes.Find(x => x.Code == code);
            return (ic != null);
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string Meldung;
        public object Data;
        public object Key;
        public eLevel Level;

        public MessageEventArgs(string meldung, string key, object data, eLevel level)
        {
            Meldung = meldung;
            Key = key;
            Data = data;
            Level = level;
            
        }

        public override string ToString()
        {
            var ky = "<NULL>";
            var meld = "<EMPTY>";
            var dt = "<NONE>";
            if (Key != null) ky = Key.ToString();
            if (!string.IsNullOrEmpty(Meldung)) meld = Meldung;
            if (Data != null)
            {
                dt = Data.GetType().ToString();
            }

            return $@"Message:{meld} Key:{ky} DataType:{dt}";
        }

    }
    public class MessageEventIntArgs : EventArgs
    {
        public int N;
        public int Max;
        public int Min;
        public bool Raise;
        private readonly int _lastValue;

        public MessageEventIntArgs(int n, int min, int max)
        {
            Raise = false;
            N = n;
            Max = max;
            Min = min;
            _lastValue = n;
        }
        public MessageEventIntArgs(int n)
        {
            Raise = true;
            N = n;
            _lastValue = n;
        }

        public MessageEventIntArgs()
        {
            Raise = true;
            _lastValue++;
            N = _lastValue;
        }
    }
    public class NotifyInfos
    {
        public delegate void RaiseNotifyHandler(object sender, MessageEventArgs k);
        public event RaiseNotifyHandler OnRaiseInfoHandler;
        public event RaiseNotifyHandler OnRaiseErrorHandler;
        public event RaiseNotifyHandler OnRaiseMessageHandler;

        public void ClearEvents()
        {
            OnRaiseInfoHandler = null;
            OnRaiseErrorHandler = null;
            
        }
        public void ClearInfoEvents()
        {
            OnRaiseInfoHandler = null;
        }
        public void ClearErrorEvents()
        {
            OnRaiseErrorHandler = null;
        }
        public void OnRaiseMessage(MessageEventArgs k)
        {
            OnRaiseMessageHandler?.Invoke(this, k);
        }
        public void OnRaiseError(MessageEventArgs k)
        {
            OnRaiseErrorHandler?.Invoke(this, k);
        }

        public List<string> GetInfoTargedList()
        {
            List<string> lst = new List<string>();
            if (OnRaiseInfoHandler == null) return lst;
            var il = OnRaiseInfoHandler.GetInvocationList();
            foreach (var i in il)
            {
                lst.Add(i.Target.ToString());
            }
            return lst;
        }
        public List<string> GetErrorTargedList()
        {
            List<string> lst = new List<string>();
            if (OnRaiseErrorHandler == null) return lst;
            var il = OnRaiseErrorHandler.GetInvocationList();
            foreach (var i in il)
            {
                lst.Add(i.Target.ToString());
            }
            return lst;
        }

        public void OnRaiseInfo(MessageEventArgs k)
        {
            
            OnRaiseInfoHandler?.Invoke(this, k);
        }
        public void RaiseMessage(eLevel level, string s, string key, object data)
        {
            var meld = new MessageEventArgs(s, key, data, level);
            OnRaiseMessage(meld);
        }
        public void RaiseMessage(eLevel level, string s, string key)
        {
            var meld = new MessageEventArgs(s, key, null, level);
            OnRaiseMessage(meld);
        }

        public void RaiseInfo(string s, string key, object data)
        {
            var meld = new MessageEventArgs(s, key, data, eLevel.info);
            OnRaiseInfo(meld);
        }

        public void RaiseInfo(string s, string key)
        {
            var meld = new MessageEventArgs(s, key, null, eLevel.info);
            OnRaiseInfo(meld);
        }
        public void RaiseInfo(string s)
        {
            var meld = new MessageEventArgs(s, string.Empty, null, eLevel.info);
            OnRaiseInfo(meld);
        }
        public void RaiseError(string s, string key, object data)
        {
            var meld = new MessageEventArgs(s, key, data, eLevel.error);
            OnRaiseError(meld);
        }

        public void RaiseError(string s, string key)
        {
            var meld = new MessageEventArgs(s, key, null, eLevel.error);
            OnRaiseError(meld);
        }
        public void RaiseError(string s)
        {
            var meld = new MessageEventArgs(s, string.Empty, null, eLevel.error);
            OnRaiseError(meld);

        }

        public void RaiseDataFilled(object data)
        {
            var meld = new MessageEventArgs(NotifyInfoCodes.DataFilled, NotifyInfoCodes.DataFilled, null, eLevel.info)
            {
                Data = data
            };
            OnRaiseInfo(meld);
        }
        public void RaiseDataSaved(object data)
        {
            var meld = new MessageEventArgs(NotifyInfoCodes.DataSaved, NotifyInfoCodes.DataSaved, data, eLevel.info)
            {
                Data = data
            };
            OnRaiseInfo(meld);
        }
        public void RaiseDataSaved()
        {
            var meld = new MessageEventArgs(NotifyInfoCodes.DataSaved, NotifyInfoCodes.DataSaved, null, eLevel.info);
            OnRaiseInfo(meld);
        }

    }
    public class NotifyGauge
    {
        public delegate void RaiseGaugeHandler(object sender, MessageEventIntArgs k);
        public event RaiseGaugeHandler OnRaiseGaugeHandler;
        private MessageEventIntArgs _meldint;

        public void ClearEvents()
        {
            OnRaiseGaugeHandler = null;
        }

        public void OnRaiseGauge(MessageEventIntArgs k)
        {
            // if (k.Raise)
            {
                OnRaiseGaugeHandler?.Invoke(this, k);
            }
        }
        public void RaiseSetGauge(int n, int min, int max)
        {
            _meldint = new MessageEventIntArgs(n, min, max)
            {
                Raise = false
            };

        }
        public void RaiseSetGauge(int n)
        {
            if (_meldint == null) _meldint = new MessageEventIntArgs(n);
            _meldint.N = n;
            _meldint.Raise = true;
            OnRaiseGauge(_meldint);
        }
        public void RaiseClearGauge()
        {
            if (_meldint == null) _meldint = new MessageEventIntArgs();
            _meldint.N = 0;
            _meldint.Max = 0;
            _meldint.Min = 0;
            _meldint.Raise = true;
            OnRaiseGauge(_meldint);
        }
        public void RaiseIncGauge()
        {
            if (_meldint == null) _meldint = new MessageEventIntArgs();
            _meldint.Raise = true;
            _meldint.N++;
            OnRaiseGauge(_meldint);
        }
    }


    public class NotifiesClass
    {
        public NotifyInfos Notify = new NotifyInfos();
        public NotifyGauge gaugeNotify = new NotifyGauge();

        private static readonly object _lockThis = new object();
        public string Name = string.Empty;
        public bool MessageTimeStamp = true;
        public bool ErrorTimeStamp = true;
        public eNotifyType NotifyType = eNotifyType.MessageOnError;
        public bool AllowErrors = true;
        public bool AllowInfos = true;
        public int MaxGauge = 0;
        public eInfoLevel InfoThreshold = eInfoLevel.normal;

        public NotifiesClass()
        {
        }

        private static NotifiesClass _instance;
        public static NotifiesClass Instance()
        {
            if (_instance != null) return _instance;
            lock (_lockThis)
            {
                _instance = new NotifiesClass();
            }
            return _instance;
        }

        public void AddToINFO(string mld, eInfoLevel level)
        {
            if (level <= InfoThreshold) Notify.RaiseInfo($@"{mld}{Environment.NewLine}");
        }

        public void AddToINFO(string mld)
        {
            Notify.RaiseInfo(mld + Environment.NewLine);
        }

        public void AddToINFO(string mld, string key)
        {
            Notify.RaiseInfo(mld + Environment.NewLine, key);
        }

        public void AddToINFO(string mld, string key, object data)
        {
            Notify.RaiseInfo(mld + Environment.NewLine, key, data);
        }

        public void AddToDataSaved(object data)
        {
            Notify.RaiseDataSaved();
        }
        public void AddToERROR(string err)
        {
            Notify.RaiseError(err + Environment.NewLine);
        }

        public void AddToERROR(string err, string key)
        {
            Notify.RaiseError(err + Environment.NewLine, key);
        }

        public void SetGaugeValue(int n, int min, int max)
        {
            gaugeNotify.RaiseSetGauge(n, min, max);
        }

        public void SetGaugeValue(int n)
        {
            gaugeNotify.RaiseSetGauge(n);
        }

        public void StartGauge(int min, int max)
        {
            gaugeNotify.RaiseSetGauge(0, min, max);
        }

        public void IncGauge()
        {
            gaugeNotify.RaiseIncGauge();
        }

        public void ClearGauge()
        {
            gaugeNotify.RaiseClearGauge();
        }
    }
}
