import { defineConfig } from '@playwright/test';

export default defineConfig({
  reporter: [['html', { outputFolder: 'playwright-report', open: 'never' }]],
  use: {
    // Dit is de fix
    testIdAttribute: 'data-testid'
  },
});
