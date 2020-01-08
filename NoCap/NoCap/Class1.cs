using SFMF;

namespace NoCap {
	public class NoCap : IMod {
		private void FixedUpdate() {
			PlayerMovement.Singleton.forwardSpeedLimits.max = 99999;
			PlayerMovement.Singleton.forwardSpeedLimits.min = -99999;
		}
	}
}