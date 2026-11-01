
'use strict';
const form = document.querySelector('#contact-form');
if (form) {
  const button = form.querySelector('button[type="submit"]');
  const status = document.querySelector('#form-status');
  const endpoint = (form.dataset.formspreeEndpoint || '').trim();
  if (endpoint && /^https:\/\/formspree\.io\/f\/[a-zA-Z0-9]+$/.test(endpoint)) {
    button.textContent = 'Send message';
    const intro = document.querySelector('#contact .small');
    if (intro) intro.textContent = 'Send a message directly using the secure contact form below.';
  }
  form.addEventListener('submit', async (event) => {
    event.preventDefault();
    if (!form.reportValidity()) return;
    const name = document.querySelector('#sender').value.trim();
    const email = document.querySelector('#sender-email').value.trim();
    const message = document.querySelector('#message').value.trim();
    if (!endpoint) {
      const subject = encodeURIComponent(`Portfolio inquiry from ${name}`);
      const body = encodeURIComponent(`From: ${name}\nReply-to: ${email}\n\n${message}`);
      status.textContent = 'Opening your email application. If it does not open, use the email address above.';
      window.location.href = `mailto:savneet1906@gmail.com?subject=${subject}&body=${body}`;
      return;
    }
    if (!/^https:\/\/formspree\.io\/f\/[a-zA-Z0-9]+$/.test(endpoint)) {
      status.textContent = 'The form endpoint is not configured correctly. Please use the email link above.';
      return;
    }
    button.disabled = true;
    status.textContent = 'Sending…';
    try {
      const response = await fetch(endpoint, {
        method: 'POST',
        body: new FormData(form),
        headers: { 'Accept': 'application/json' }
      });
      if (!response.ok) throw new Error('Submission failed');
      form.reset();
      status.textContent = 'Thank you. Your message was sent.';
    } catch (error) {
      status.textContent = 'Your message could not be sent. Please email me using the link above.';
    } finally { button.disabled = false; }
  });
}
