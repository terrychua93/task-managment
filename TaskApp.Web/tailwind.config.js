// tailwind.config.js
export default {
    content: [
    './**/*.{razor,html}',
    './**/(Layout|Pages)/*.{razor,html}', // Include only Layout and Pages folders
    ],
  theme: {
    extend: {},
  },
  plugins: [],
}