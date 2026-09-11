// ============================================================
// Mobile nav toggle
// ============================================================
(function () {
  const toggle = document.getElementById('navToggle');
  const links = document.getElementById('navLinks');
  if (!toggle || !links) return;

  toggle.addEventListener('click', () => {
    const isOpen = links.classList.toggle('is-open');
    toggle.setAttribute('aria-expanded', String(isOpen));
  });

  links.querySelectorAll('a').forEach(a => {
    a.addEventListener('click', () => {
      links.classList.remove('is-open');
      toggle.setAttribute('aria-expanded', 'false');
    });
  });
})();

// ============================================================
// Hero background: connected nodes (integration/circuit motif)
// ============================================================
(function () {
  const canvas = document.getElementById('nodeCanvas');
  if (!canvas) return;
  const ctx = canvas.getContext('2d');
  const reduceMotion = window.matchMedia('(prefers-reduced-motion: reduce)').matches;

  let width, height, nodes;
  const NODE_COUNT = 42;
  const LINK_DIST = 150;

  function resize() {
    width = canvas.width = canvas.offsetWidth * devicePixelRatio;
    height = canvas.height = canvas.offsetHeight * devicePixelRatio;
  }

  function init() {
    resize();
    nodes = Array.from({ length: NODE_COUNT }, () => ({
      x: Math.random() * width,
      y: Math.random() * height,
      vx: (Math.random() - 0.5) * 0.25 * devicePixelRatio,
      vy: (Math.random() - 0.5) * 0.25 * devicePixelRatio,
    }));
  }

  function step() {
    ctx.clearRect(0, 0, width, height);
    for (const n of nodes) {
      n.x += n.vx; n.y += n.vy;
      if (n.x < 0 || n.x > width) n.vx *= -1;
      if (n.y < 0 || n.y > height) n.vy *= -1;
    }
    for (let i = 0; i < nodes.length; i++) {
      for (let j = i + 1; j < nodes.length; j++) {
        const a = nodes[i], b = nodes[j];
        const dist = Math.hypot(a.x - b.x, a.y - b.y);
        if (dist < LINK_DIST * devicePixelRatio) {
          ctx.strokeStyle = `rgba(79,209,255,${0.16 * (1 - dist / (LINK_DIST * devicePixelRatio))})`;
          ctx.lineWidth = 1;
          ctx.beginPath();
          ctx.moveTo(a.x, a.y);
          ctx.lineTo(b.x, b.y);
          ctx.stroke();
        }
      }
    }
    for (const n of nodes) {
      ctx.fillStyle = 'rgba(139,92,246,0.55)';
      ctx.beginPath();
      ctx.arc(n.x, n.y, 1.6 * devicePixelRatio, 0, Math.PI * 2);
      ctx.fill();
    }
    if (!reduceMotion) requestAnimationFrame(step);
  }

  window.addEventListener('resize', () => { resize(); });
  init();
  step();
})();

// ============================================================
// Project filtering
// ============================================================
(function () {
  const filterBar = document.getElementById('projectFilters');
  const grid = document.getElementById('projectGrid');
  if (!filterBar || !grid) return;

  const cards = Array.from(grid.querySelectorAll('.project-card'));

  filterBar.addEventListener('click', (e) => {
    const btn = e.target.closest('.filter-btn');
    if (!btn) return;
    filterBar.querySelectorAll('.filter-btn').forEach(b => b.classList.remove('is-active'));
    btn.classList.add('is-active');

    const filter = btn.dataset.filter;
    cards.forEach(card => {
      const tech = card.dataset.tech || '';
      const matches = filter === 'all' || tech.includes(filter);
      card.classList.toggle('is-hidden', !matches);
    });
  });
})();

// ============================================================
// Project detail modal
// ============================================================
(function () {
  const modal = document.getElementById('projectModal');
  const closeBtn = document.getElementById('modalClose');
  const titleEl = document.getElementById('modalTitle');
  const descEl = document.getElementById('modalDesc');
  const listEl = document.getElementById('modalHighlights');
  if (!modal) return;

  document.querySelectorAll('.project-details-btn').forEach(btn => {
    btn.addEventListener('click', () => {
      const card = btn.closest('.project-card');
      titleEl.textContent = card.querySelector('h3').textContent;
      descEl.textContent = card.querySelector('.project-desc').textContent;
      listEl.innerHTML = '';
      // Highlights aren't in the DOM directly, so re-derive from tech pills as a fallback view
      card.querySelectorAll('.tech-pill').forEach(pill => {
        const li = document.createElement('li');
        li.textContent = pill.textContent;
        listEl.appendChild(li);
      });
      modal.classList.add('is-open');
      modal.setAttribute('aria-hidden', 'false');
    });
  });

  function close() {
    modal.classList.remove('is-open');
    modal.setAttribute('aria-hidden', 'true');
  }

  closeBtn.addEventListener('click', close);
  modal.addEventListener('click', (e) => { if (e.target === modal) close(); });
  document.addEventListener('keydown', (e) => { if (e.key === 'Escape') close(); });
})();

// ============================================================
// Contact form (posts to HomeController.Contact)
// ============================================================
(function () {
  const form = document.getElementById('contact-form');
  const status = document.getElementById('formStatus');
  if (!form) return;

  form.addEventListener('submit', async (e) => {
    e.preventDefault();
    status.textContent = 'Sending...';
    status.className = 'form-status';

    const formData = new FormData(form);
    try {
      const res = await fetch('/Home/Contact', { method: 'POST', body: formData });
      const data = await res.json();
      if (data.success) {
        status.textContent = "Thanks — your message has been sent.";
        status.className = 'form-status is-success';
        form.reset();
      } else {
        status.textContent = data.error || 'Something went wrong. Please try again.';
        status.className = 'form-status is-error';
      }
    } catch (err) {
      status.textContent = 'Network error — please email ko.moduto@gmail.com directly.';
      status.className = 'form-status is-error';
    }
  });
})();
