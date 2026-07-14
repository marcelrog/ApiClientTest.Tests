import { defineConfig } from '@playwright/test';

export default defineConfig({
testDir: './ui',
  use: {
    headless: true,
    viewport: { width: 1280, height: 720 },
  },
});
