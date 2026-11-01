# Savneet Kaur | TCOM291 Portfolio (Step 3)

## Preview
Extract the ZIP, keep the folder structure, and open `index.html` in your browser. Do not open the HTML from inside the ZIP.

## Publish free on GitHub Pages
1. Create a **public** repository named `savneet-portfolio` on https://github.com/kaursavneet.
2. Upload **the contents of this folder**, not the ZIP. Keep `index.html` in the repository root.
3. Open Settings → Pages → Build and deployment → Deploy from a branch.
4. Choose `main` and `/(root)`; save.
5. Open the URL GitHub provides, usually `https://kaursavneet.github.io/savneet-portfolio/` (verify the exact URL on GitHub).
6. Test in an incognito window. Check navigation, resume View/Download, three project exhibits, GitHub, LinkedIn and email.

## Contact form
The included form is an honest `mailto:` fallback, not a server-submitted form. It requires the visitor's configured email app. For a real hosted form:
1. Sign up for a free Formspree account at https://formspree.io/ and verify your email.
2. Create a new form and copy its endpoint (looks like `https://formspree.io/f/xxxxxxxx`).
3. In `index.html`, replace `<form class="contactform" id="contact-form">` with `<form class="contactform" action="YOUR_FORM_ENDPOINT" method="POST">`.
4. Change the button text from `Prepare email message` to `Send message`.
5. Remove `<script src="script.js"></script>` from `index.html` so the browser submits to Formspree.
6. Republish, send a real test message, verify receipt and confirm the success/error behavior. Formspree limits and terms may change.

## Still needed
- Full original music website has been integrated under `music-website/Views/index.html`.
- Confirm teaching certificate titles and graduation information against resume.
- Confirm the resume contains no phone number, street address, references or other people's private information before publishing.
- Add further soft-skills artifacts if available, and independently test the live site.

## Integrated music website
The original HTML, CSS, images, and product detail pages are included. Links have been normalized for case-sensitive GitHub Pages hosting. This is an academic exhibit, not an online store. Test all product links after publishing.

Hospital Management System: the primary artifact links to https://github.com/Abbysmal314/HospitalManagement (student-owned code hosted on a fellow student’s account).

AVL Tree Implementation in C#: primary GitHub artifact https://github.com/kaursavneet/AVL-Tree_assignment; existing C# and worksheet artifacts retained.

## Latest update
- Hero headline changed to “TURNING IDEAS INTO CODE.” with “Building experiences that matter.” beneath it.
- Added C#, Java, HTML, CSS, JavaScript, and SQL technology line.
- Other projects, links, and layout preserved.


## Rubric improvements (November 1, 2026)
- Listed exact Saskatchewan and British Columbia teaching credential names, as shown in the supplied resume.
- Added a clearly labelled first-person professional-skills case study link. No private student materials are published.
- Strengthened the AVL results statement using the four rotation cases already discussed, without inventing a grade or benchmark.
- Added optional direct Formspree submission with honest email fallback.

## Enable direct contact form submission (required for strongest rubric score)
1. Create a free account at https://formspree.io/ and verify your email.
2. Create a new form that sends submissions to savneet1906@gmail.com.
3. Copy the endpoint, which looks like https://formspree.io/f/abcdefgh.
4. Open `index.html` in VS Code. Search for `data-formspree-endpoint=""` and replace it with `data-formspree-endpoint="https://formspree.io/f/YOUR_ACTUAL_ID"`.
5. Save, publish the entire folder on GitHub Pages, and submit a test message from an incognito browser. Confirm receipt.
6. Until this is configured, the form truthfully opens an email app rather than claiming direct delivery.

## Before submission
- Publish the folder (not the ZIP) on GitHub Pages and test the public link in incognito.
- Open the resume PDF, all project artifacts, music-site product pages, and both GitHub repository links.
- Consider adding a privacy-safe original digital worksheet only if you have one and are permitted to publish it.
- Review all claims and check the final site on mobile and desktop.


FINAL SUBMISSION CHECKLIST
- Resume PDF no longer contains a phone number.
- Music website HTML pages include portfolio attribution and last-updated date.
- Unused duplicate HTML copies in assets/ were removed.
- The original music project design and portfolio theme were retained.
- To activate direct contact form delivery, configure a Formspree endpoint and test a submission.
- Add your own professional portrait only if you want one; no image has been invented.
- Add a genuine privacy-safe teaching worksheet or reference letter if available.
- Publish on GitHub Pages and test every link in an incognito window and on mobile.

The original 14-page Pronouns booklet is included at assets/Pronouns_Booklet.pdf and linked in the Professional Strengths section.


SUBMISSION CHECKS (November 1, 2026)
- Resume PDF was checked for phone-number text and none was found.
- All 13 included music-website HTML pages have author and last-updated attribution.
- Original Pronouns booklet (14 pages) and its preview are included. Check it manually for any student-identifying information before publishing.
- The music project has 13 included HTML pages; this is a verified count, not a claim that all published links work.
- Contact form is currently an email-composition fallback, NOT direct delivery. To enable direct Formspree submission, create and verify a form at formspree.io and set the form's data-formspree-endpoint attribute in index.html to your real https://formspree.io/f/FORM_ID endpoint. The existing script.js automatically switches the button to 'Send message' when a valid endpoint is present. Keep script.js; removing it without configuring a form action would break this implementation. Send a test message to verify delivery.
- Hospital Management System GitHub repository belongs to another account. Move it to your own account only after you have access and permission; then update its portfolio URL.
- Publish all files to GitHub Pages and verify every link, image, and form on mobile and in an incognito window.
