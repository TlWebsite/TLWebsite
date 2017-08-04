import { TLWebsite.WebPage } from './app.po';

describe('tlwebsite.web App', () => {
  let page: TLWebsite.WebPage;

  beforeEach(() => {
    page = new TLWebsite.WebPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
