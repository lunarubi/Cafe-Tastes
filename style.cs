:root{
  --bg:#f9efe4;
  --phone:#fff7ef;
  --frame:#6b4125;
  --accent:#6b4125;
  --muted:#8c6a4e;
  --shade:#f3e6d6;
  --radius:26px;
  --phone-w:320px;
  --phone-h:640px;
}

/* Global */
body{
  margin:0;
  background:var(--bg);
  font-family:Segoe UI, Arial;
  color:var(--frame);
}

.wrap{ max-width:1100px; margin:28px auto; padding:28px; }

.title{ font-size:38px; margin:0 0 8px 8px; }
.subtitle{ margin:0 0 28px 8px; color:var(--muted); font-weight:600; }

/* Phone Container */
.viewport{
  width:var(--phone-w);
  height:var(--phone-h);
  margin:auto;
  border-radius: calc(var(--radius) + 6px);
  background:linear-gradient(180deg, var(--phone), var(--shade));
  border:10px solid rgba(107,65,37,0.08);
  overflow:hidden;
  position:relative;
}

/* Track */
.track{
  display:flex;
  width:calc(var(--phone-w) * 8);
  height:100%;
}

/* Screens */
.phone{
  width:var(--phone-w);
  height:100%;
  padding:28px;
  display:flex;
  flex-direction:column;
  gap:12px;
  box-sizing:border-box;
}

.panel{ align-items:center; }

/* Buttons, fields */
.field{
  width:100%;
  padding:12px;
  border-radius:10px;
  border:1px solid rgba(107,65,37,0.15);
  background:#fff;
}

.accent-btn{
  background:var(--accent);
  color:white;
  padding:12px 18px;
  border-radius:12px;
  font-weight:700;
  margin-top:auto;
  box-shadow:0 4px 8px rgba(0,0,0,0.1);
}

/* Simple icons */
.cup{
  font-size:40px;
  border:7px solid var(--frame);
  width:84px;
  height:84px;
  border-radius:20px;
  display:flex;
  align-items:center;
  justify-content:center;
  margin-bottom:12px;
}

/* Animation (starts only when JS adds it) */
@keyframes slide{
  0%   { transform:translateX(0); }
  100% { transform:translateX(calc(-1 * var(--phone-w) * 7)); }
}