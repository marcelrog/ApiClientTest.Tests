import { test, expect } from '@playwright/test';
import path from 'path';

// Nodig in TS wanneer __dirname niet automatisch bestaat
// declare const __dirname: string;

test('demo login werkt', async ({ page }) => {
  const filePath = path.join(__dirname, 'demo-login.html');
  await page.goto('file://' + filePath);

  await page.fill('#username', 'testuser');
  await page.fill('#password', 'secret');
  await page.click('#login');

  await expect(page.locator('#welcome')).toBeVisible();
});
