using UnityEngine;

namespace Chess.Game {
	[CreateAssetMenu(menuName = "Theme/Board3D")]
	public class BoardTheme3D : ScriptableObject {
		public SquareColours lightSquares;
		public SquareColours darkSquares;

		[System.Serializable]
		public struct SquareColours
		{
			public Color normal;
			public Color legal;
			public Color selected;
			public Color moveFromHighlight;
			public Color moveToHighlight;
		}
	}
}
