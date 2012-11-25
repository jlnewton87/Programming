/*
 * GX - Javascript Full-Featured Animations Framework - Transitions
 *
 * Easing Equations by Robert Penner (http://www.robertpenner.com/easing/ - BSD License), adapted for dealing with GX
 * MIT-Style License
 */

Fns.Extend(GX.Transitions, {
	Sine: {
		'In':function(t,b,c,d) { return-c*Math.cos(t/d*(Math.PI/2))+c+b; },
		'Out':function(t,b,c,d) { return c*Math.sin(t/d*(Math.PI/2))+b; },
		'InOut':function(t,b,c,d) { return-c/2*(Math.cos(Math.PI*t/d)-1)+b; }
	},
	
	Quint: {
		'In':function(t,b,c,d) { return c*(t/=d)*t*t*t*t+b; },
		'Out':function(t,b,c,d) { return c*((t=t/d-1)*t*t*t*t+1)+b; },
		'InOut':function(t,b,c,d) { return ((t/=d/2)<1) ? c/2*t*t*t*t*t+b : c/2*((t-=2)*t*t*t*t+2)+b; }
	},
	
	Quart: {
		'In':function(t,b,c,d) { return c*(t/=d)*t*t*t+b; },
		'Out':function(t,b,c,d) { return-c*((t=t/d-1)*t*t*t-1)+b; },
		'InOut':function(t,b,c,d) { return ((t/=d/2)<1) ? c/2*t*t*t*t+b : -c/2*((t-=2)*t*t*t-2)+b; }
	},
	
	Quad: {
		'In':function(t,b,c,d) { return c*(t/=d)*t+b; },
		'Out':function(t,b,c,d) { return-c*(t/=d)*(t-2)+b; },
		'InOut':function(t,b,c,d) { return ((t/=d/2)<1) ? c/2*t*t+b : -c/2*((--t)*(t-2)-1)+b; }
	},
	
	Expo: {
		'In':function(t,b,c,d) { return(t==0)?b:c*Math.pow(2, 10*(t/d-1))+b; },
		'Out':function(t,b,c,d) { return(t==d)?b+c:c*(-Math.pow(2,-10*t/d)+1)+b; },
		'InOut':function(t,b,c,d) { return (t==0) ? b : ((t==d) ? b+c : ((t/=d/2)<1) ?  c/2*Math.pow(2, 10*(t-1))+b : c/2*(-Math.pow(2,-10*--t)+2)+b); }
	},
	
	Elastic: {
		'In':function(t,b,c,d) {
			if(t==0) return b; if((t/=d)==1) return b+c; var p=d*.3, a=c, s=p/4;
			return-(a*Math.pow(2,10*(t-=1))*Math.sin((t*d-s)*(2*Math.PI)/p))+b;
		},
		'Out':function(t,b,c,d,a,p) {
			if(t==0) return b; if((t/=d)==1) return b+c; var p=d*.3, a=c, s=p/4;
			return(a*Math.pow(2,-10*t)*Math.sin((t*d-s)*(2*Math.PI)/p)+c+b);
		},
		'InOut':function(t,b,c,d,a,p) {
			if(t==0) return b; if((t/=d/2)==2) return b+c; var p=d*(.3*1.5), a=c, s=p/4;
			return (t<1) ? -.5*(a*Math.pow(2,10*(t-=1))*Math.sin((t*d-s)*(2*Math.PI)/p))+b : a*Math.pow(2,-10*(t-=1))*Math.sin((t*d-s)*(2*Math.PI)/p)*.5+c+b;
		}
	},
	
	Cubic: {
		'In':function(t,b,c,d) { return c*(t/=d)*t*t+b; },
		'Out':function(t,b,c,d) { return c*((t=t/d-1)*t*t+1)+b; },
		'InOut':function(t,b,c,d) { return ((t/=d/2)<1) ? c/2*t*t*t+b : c/2*((t-=2)*t*t+2)+b; }
	},
	
	Circ: {
		'In':function(t,b,c,d) { return-c*(Math.sqrt(1-(t/=d)*t)-1)+b; },
		'Out':function(t,b,c,d) { return c*Math.sqrt(1-(t=t/d-1)*t)+b; },
		'InOut':function(t,b,c,d) { return ((t/=d/2)<1) ? -c/2*(Math.sqrt(1-t*t)-1)+b : c/2*(Math.sqrt(1-(t-=2)*t)+1)+b; }
	},
	
	Bounce: {
		'In':function(t,b,c,d) { return c-GX.Transitions.Bounce.Out(d-t, 0, c, d)+b; },
		'Out':function(t,b,c,d) { return ((t/=d)<(1/2.75)) ? c*(7.5625*t*t)+b : ((t<(2/2.75)) ? c*(7.5625*(t-=(1.5/2.75))*t+.75)+b : (t<(2.5/2.75) ? c*(7.5625*(t-=(2.25/2.75))*t+.9375)+b : c*(7.5625*(t-=(2.625/2.75))*t+.984375)+b )); },
		'InOut':function(t,b,c,d) { return (t<d/2) ? (GX.Transitions.Bounce.In(t*2, 0, c, d)*.5+b) : (GX.Transitions.Bounce.Out(t*2-d, 0, c, d)*.5+c*.5+b); }
	},
	
	Back: {
		'In':function(t,b,c,d) { var s=1.70158; return c*(t/=d)*t*((s+1)*t-s)+b; },
		'Out':function(t,b,c,d) { var s=1.70158; return c*((t=t/d-1)*t*((s+1)*t+s)+1)+b; },
		'InOut':function(t,b,c,d) { var s=1.70158; return ((t/=d/2)<1) ? c/2*(t*t*(((s*=(1.525))+1)*t-s))+b : c/2*((t-=2)*t*(((s*=(1.525))+1)*t+s)+2)+b; }
	}
});