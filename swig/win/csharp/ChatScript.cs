/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace ChatScript {

public class ChatScript {
  public static int InitSystem(int argc, SWIGTYPE_p_p_char argv, string unchangedPath, string readonlyPath, string writablePath) {
    int ret = ChatScriptPINVOKE.InitSystem__SWIG_0(argc, SWIGTYPE_p_p_char.getCPtr(argv), unchangedPath, readonlyPath, writablePath);
    return ret;
  }

  public static int InitSystem(int argc, SWIGTYPE_p_p_char argv, string unchangedPath, string readonlyPath) {
    int ret = ChatScriptPINVOKE.InitSystem__SWIG_1(argc, SWIGTYPE_p_p_char.getCPtr(argv), unchangedPath, readonlyPath);
    return ret;
  }

  public static int InitSystem(int argc, SWIGTYPE_p_p_char argv, string unchangedPath) {
    int ret = ChatScriptPINVOKE.InitSystem__SWIG_2(argc, SWIGTYPE_p_p_char.getCPtr(argv), unchangedPath);
    return ret;
  }

  public static int InitSystem(int argc, SWIGTYPE_p_p_char argv) {
    int ret = ChatScriptPINVOKE.InitSystem__SWIG_3(argc, SWIGTYPE_p_p_char.getCPtr(argv));
    return ret;
  }

  public static void PerformChat(string user, string usee, string incoming, string ip, System.Text.StringBuilder output) {
    ChatScriptPINVOKE.PerformChat(user, usee, incoming, ip, output);
  }

}

}
