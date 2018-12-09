using UnityEngine;

namespace Xyz.AnzFactory.Utils
{
	/// <summary>
	/// orthographicSize って縦基準の設定なので、
	/// それの横基準で設定出来るようにするやつ
	/// </summary>
	public class OrthographicWidthFitter: MonoBehaviour
	{
		#region "SerializeFields"
		/// <summary>
		/// 画面横に表示するunit数
		/// </summary>
		[SerializeField] private float displayWidthUnit;
		#endregion
		
		#region "Fields"
		private Camera targetCamera;
		#endregion
		
		#region "Properties"
		#endregion
		
		#region "Lifecycles"
		private void Awake()
		{
			targetCamera = GetComponent<Camera>();
		}
		
		private void Start () 
		{
			var ratio = ((float)Screen.width / (float)Screen.height);
			targetCamera.orthographicSize = (displayWidthUnit * 0.5f) / ratio;
		}
		#endregion
		
		#region "Events"
		#endregion
		
		#region "Methods"
		#endregion
		
	}
}